using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using VegunSoft.App.Repository.Business.View;
using VegunSoft.App.View.Service.Services;
using VegunSoft.Base.Model.Business;
using VegunSoft.Framework.Db;
using VegunSoft.Framework.Db.Models;
using VegunSoft.Framework.Db.Models.Entity;
using VegunSoft.Framework.Db.Services;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Message;
using VegunSoft.Framework.Gui.Models.Message;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Subscribe;
using VegunSoft.Message.MService.Provider.Methods;
using VegunSoft.Message.Service.App;
using VegunSoft.Session.Repository.Business;
using VegunSoft.Session.Service.User;

namespace VegunSoft.App.View.Service.Dev.Services
{
    public class MgmtViewService : IMgmtViewService
    {
        private IIocService _dbIoc;
        protected IIocService DbIoc => _dbIoc ?? (_dbIoc = XIoc.GetService(CDb.IocKey));
        private IRepositoryForm _repositoryForm;
        protected IRepositoryForm RepositoryForm => _repositoryForm ?? (_repositoryForm = DbIoc.GetInstance<IRepositoryForm>());
        protected virtual string RightsCode { get; set; }
        public virtual string DataName { get; set; } = "thông tin";
       
        public bool IsUpdating { get; set; }= false;

        private IIocService _guiIoc;
        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));
        private IAppMessage _msg;
        protected IAppMessage Msg => _msg ?? (_msg = GuiIoc.GetInstance<IAppMessage>());
        private ICheckRightsService _checkRightsService;
        protected ICheckRightsService CheckRightsService => _checkRightsService ?? (_checkRightsService = GuiIoc.GetInstance<ICheckRightsService>());

        private IMMgmtViewService _model;
        private GridView _gridView;
        private Form _form;
        private bool _isDbSaving;
        private IRepositorySession _sessionRepository;

     
        private IDbValueRepository _dbo;
        protected IDbValueRepository Dbo => _dbo ?? (_dbo = DbIoc.GetInstance<IDbValueRepository>());

        private string _sessionCode;
        protected virtual string SessionCode => _sessionCode ?? (_sessionCode = XForm.GetSessionCode(_form));
        public MgmtViewService()
        {
           
            _sessionRepository = DbIoc.GetInstance<IRepositorySession>();
          
        }

        public IMgmtViewService Init(IMMgmtViewService model)
        {
            _model = model;
            _form = model.Form as Form;
            RightsCode = _form.Name;
            _gridView = model.GridView as GridView;
            return this;
        }

        public IMgmtViewService Prepare()
        {
            if (_model.PreapreActions == null || _model.PreapreActions.Length <= 0) return this;
            foreach (var action in _model.PreapreActions)
            {
                action?.Invoke();
            }

            return this;
        }

        public IMgmtViewService Reload()
        {
            _model.SetReadOnlyAction?.Invoke(true);
            _model.ResetValueAction?.Invoke();
            _model.LoadGridAction?.Invoke();

            return this;
        }

        private bool IsCanSave()
        {
            if (_model.RequiredFields == null || _model.RequiredFields.Length == 0) return true;
            var canSave = true;
            var sb = new StringBuilder();
            foreach (var field in _model.RequiredFields)
            {
                if (field is TextEdit textEdit)
                {
                    if (textEdit.Text.Trim() == "") // bắt buộc nhập
                    {
                        if (_model.LabelDicts != null && _model.LabelDicts.ContainsKey(textEdit.Name))
                        {
                            var label = _model.LabelDicts[textEdit.Name];
                            sb.AppendLine(label.GetEmptyMessage());
                        }
                    }
                }

            }
            var error = sb.ToString();
            if (!string.IsNullOrWhiteSpace(error))
            {
                canSave = false;
                Msg.ShowError(error);
                XEvent.Publish(new MQuickMessage
                {
                    Type = EMessage.Error,
                    Title = error
                });
            }
            return canSave;
        }

        public IMgmtViewService OnClickSaveNewButton()
        {
            IsUpdating = false;
            OnClickSaveButton();
            return this;
        }

        public IMgmtViewService OnClickSaveButton()
        {
            try
            {
                UpdateAddOnlyFields(false);
                if (IsCanSave())
                {
                    string vId;

                    if (IsUpdating)
                    {

                        vId = _model.GetModelIdFunc.Invoke();
                        _isDbSaving = true;
                        if (_model.UpdateFunc.Invoke())
                        {
                            _isDbSaving = false;
                            if (_model.IsShowPopupSuccessMessageAfterSave)
                            {
                                Msg.ShowInfo(DataName.GetUpdateSuccessMessage());
                            }
                            else
                            {
                                XEvent.Publish(new MQuickMessage
                                {
                                    Type = EMessage.Success,
                                    Title = DataName.GetUpdateSuccessMessage()
                                });
                            }

                            IsUpdating = false;

                            //var mLog = new ObQTHT_System_Log()
                            //{
                            //    ID_FORM = _objQTHT_Form?.ID,
                            //    TEN_FORM = _objQTHT_Form?.TEN,
                            //    DOITUONG = _form.Text,
                            //    ACTION = ERights.SUA.ToString(),
                            //    ID_DOITUONG = vId.ToString()
                            //};
                            //_crudLog.Save(mLog);
                          
                          

                        }
                        else
                        {
                            Msg.ShowInfo(DataName.GetUpdateErrorMessage());
                        }
                    }
                    else
                    {
                        _isDbSaving = true;
                        vId = _model.AddAndGetIdFunc.Invoke();
                        _isDbSaving = false;
                        int intId;
                        var isAddOK = (!_model.IsUseIntId && !string.IsNullOrWhiteSpace(vId)) || (_model.IsUseIntId && int.TryParse(vId, out intId) && intId > 0);
                        if (isAddOK)
                        {
                            if (_model.IsShowPopupSuccessMessageAfterSave)
                            {
                                Msg.ShowInfo(DataName.GetInsertSuccessMessage());
                            }
                            else
                            {
                                XEvent.Publish(new MQuickMessage
                                {
                                    Type = EMessage.Success,
                                    Title = DataName.GetInsertSuccessMessage()
                                });
                            }


                            //var mLog = new ObQTHT_System_Log()
                            //{
                            //    ID_FORM = _objQTHT_Form?.ID,
                            //    TEN_FORM = _objQTHT_Form?.TEN,
                            //    DOITUONG = _form.Text,
                            //    ACTION = ERights.THEM.ToString(),
                            //    ID_DOITUONG = vId.ToString()
                            //};
                            //_crudLog.Save(mLog);
                        }
                        else
                        {
                            Msg.ShowInfo(DataName.GetInsertErrorMessage());
                        }
                    }
                    _model.ResetValueAction?.Invoke();
                    Reload();
                    if (_model.IsAutoAddNewAfterSave)
                    {
                        OnClickAddButton(false);
                    }
                }
            }
            catch (Exception e)
            {
                _isDbSaving = false;
                Msg.ShowError(e.Message);
                XEvent.Publish(new MQuickMessage
                {
                    Type = EMessage.Error,
                    Title = e.Message
                });
            }
            
            return this;
        }

       

        public IMgmtViewService OnClickAddButton(bool isReset = true)
        {
            if (CheckRightsService.CheckCanAdd(SessionCode, _model.CheckRightsCode))
            {
                _model.SetReadOnlyAction?.Invoke(false);
                IsUpdating = false;
                if(isReset) _model.ResetDataAction?.Invoke();
            }
            return this;
        }

        public IMgmtViewService OnClickCancelButton(bool isReset = true)
        {
          
            IsUpdating = false;
            _model.ResetDataAction?.Invoke();
            _model.SetReadOnlyAction?.Invoke(true);
            return this;
        }

        public IMgmtViewService OnClickDeleteCell()
        {
            if (CheckRightsService.CheckCanDelete(SessionCode, _model.CheckRightsCode))
            {
                if (Msg.IsAgree(DataName.GetConfirmDeleteMessage()))
                {
                    try
                    {
                        var _obj = _gridView.GetFocusedRow();
                        var json = _obj != null ? JsonConvert.SerializeObject(_obj) : string.Empty;
                        var id = _model.GetIdFunc.Invoke(_obj);
                        _model.DeleteFunc.Invoke(_obj);
                        //var mLog = new ObQTHT_System_Log()
                        //{
                        //    ID_FORM = _objQTHT_Form?.ID,
                        //    TEN_FORM = _objQTHT_Form?.TEN,
                        //    DOITUONG = _form.Text,
                        //    ACTION = ERights.XOA.ToString(),
                        //    ID_DOITUONG = id,
                        //    Data = json
                        //};
                        //_crudLog.Save(mLog);
                        Reload();
                    }
                    catch (Exception e)
                    {
                        Msg.ShowError(e.Message);
                        XEvent.Publish(new MQuickMessage
                        {
                            Type = EMessage.Error,
                            Title = e.Message
                        });
                    }
                    
                }
            }
            return this;
        }

        public IMgmtViewService OnClickEditCell()
        {
            if (CheckRightsService.CheckCanEdit(SessionCode, _model.CheckRightsCode))
            {
                IsUpdating = true;
                _model.SetReadOnlyAction?.Invoke(false);
               
                var selectedModel = _gridView.GetFocusedRow();
                if (_model.IsReportMode)
                {
                    _model.SetFormModelAction?.Invoke(selectedModel);
                }
                else
                {
                    var _id = _model.GetIdFunc.Invoke(selectedModel);
                    var findedModel = _model.FindFunc.Invoke(_id);

                    _model.SetFormModelAction?.Invoke(findedModel);
                }
               

                UpdateAddOnlyFields(true);
            }
            return this;
        }

        public IMgmtViewService OnFormClosing()
        {
            if (_gridView.FocusedRowHandle >= 0)
            {
                _model.SetRawModelAction?.Invoke(_gridView.GetRow(_gridView.FocusedRowHandle));
            }
            return this;
        }


        private void UpdateAddOnlyFields(bool isReadOnly)
        {
            if (_model.AddOnlyFields == null || _model.AddOnlyFields.Length == 0) return;
            foreach (var field in _model.AddOnlyFields)
            {
                if (field is TextEdit textEdit)
                {
                    textEdit.Properties.ReadOnly = isReadOnly;
                }
            }
        }


        //IEntityBase, IModelBasic
        public T PrepareBeforeSave<T>(IEntityBase entity) where T : class, IEntityBase
        {
            if (entity == null) return null;
            var dbDateTime = Dbo.GetDateTime();

            if(entity is IModelBasic model)
            {
                if (IsUpdating)
                {
                    _sessionRepository.ApplyUpdatedBasicFields(model, dbDateTime);
                }
                else
                {
                    _sessionRepository.ApplyCreatedBasicFields(model, dbDateTime);
                    _sessionRepository.ApplyUpdatedBasicFields(model, dbDateTime);
                }
            }
            else
            {
                if (IsUpdating)
                {
                    _sessionRepository.ApplyUpdatedValues(entity, dbDateTime);
                }
                else
                {
                    _sessionRepository.ApplyCreatedValues(entity, dbDateTime);
                    _sessionRepository.ApplyUpdatedValues(entity, dbDateTime);
                }
            }

           
            return entity as T;
        }


    }
}
