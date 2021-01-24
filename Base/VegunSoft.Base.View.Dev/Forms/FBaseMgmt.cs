using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Methods;
using VegunSoft.Layer.Entity.Provider.App;
using VegunSoft.Layer.EValue.Acc;
using VegunSoft.Layer.EValue.Message;

namespace VegunSoft.Base.View.Dev.Forms
{
    public class FBaseMgmt: FBase
    {

        protected bool CanChangeWorkingDateTime(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanChangeWorkingDateTime(SessionCode, rightsCode);
        }

        protected bool CanAdd(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanAdd(SessionCode, rightsCode, true);
        }

      
       
        protected bool CanEdit(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanEdit(SessionCode, rightsCode, true);
        }

        protected bool CanDelete(string rightsCode = null)
        {
            if (string.IsNullOrWhiteSpace(rightsCode)) rightsCode = RightsCode;
            return CheckRightsService.CheckCanDelete(SessionCode, rightsCode, true);
        }

        protected MEntitySystemLog GetNewLog(ERights type)
        {
            var logEntity = new MEntitySystemLog() {
                ID_FORM = FModel?.Id,
                TEN_FORM = FModel?.Name,
                DOITUONG = this.Text,
                ACTION = type.ToString(),
            };

            return logEntity;
        }

        
        protected void UpdateDeleteLog(object entity, MEntitySystemLog logEntity, Action<MEntitySystemLog> action = null)
        {
            //TODO: Use entity
            action?.Invoke(logEntity);
        }

        protected void SaveChangesLog(MEntitySystemLog logEntity, bool isSuccess)
        {
            if (isSuccess)
            {
                LogRepository.Save(logEntity);
            }          
        }

        protected void ClickDelete(Func<MEntitySystemLog, bool> func, string rightsCode = null)
        {
            if (IsPrivateRow() || CanDelete(rightsCode))
            {
                if (Msg.IsAgree(string.Format(EMsg.DeleteQuestionTpl.GetText(), DataName)))
                {
                    XLoading.ShowLoading();
                    try
                    {
                        var logEntity = GetNewLog(ERights.XOA);
                        var isSuccess = func?.Invoke(logEntity) ?? false;
                        SaveChangesLog(logEntity, isSuccess);
                        if (isSuccess)
                        {
                            Msg.ShowDeleteSuccessInfo(DataName, true);
                            XLoading.CloseLoading();
                        }
                        else
                        {
                            XLoading.CloseLoading();
                            Msg.ShowDeleteErrorInfo(DataName);
                        }
                    }
                    catch (Exception ex)
                    {
                        XLoading.CloseLoading();
                        Msg.ShowException(ex);
                    }
                   
                }
            }
        }

      
        protected void ClickAdd(Func<bool> func, string rightsCode = null)
        {
            if (CanAdd(rightsCode))
            {
                //XLoading.ShowLoading();
                func?.Invoke();
                //XLoading.CloseLoading();
            }
        }

      

        protected void ClickInsert(Func<StringBuilder, bool> checckFunc, Func<bool> func, string rightsCode = null)
        {
            var sb = new StringBuilder();
            var hasError = false;
            if (checckFunc?.Invoke(sb) ?? true)
            {
                if (CanAdd(rightsCode))
                {
                    func?.Invoke();
                }
            }
            else
            {
                hasError = true;
            }
            var msg = sb.ToString();
            if (!string.IsNullOrWhiteSpace(msg))
            {
                if (hasError)
                {
                    Msg.ShowError(msg);
                }
                else
                {
                    Msg.ShowInfo(msg, true);
                }
            }           
        }

        protected void ClickEdit(Func<bool> func, string rightsCode = null)
        {
            if (IsPrivateRow() || CanEdit(rightsCode))
            {
                func?.Invoke();
            }
        }

        protected void ShowReferenceForm<TEnum>(TEnum formEnum, Func<Form> getFormFunc, Func<Form, bool> func) where TEnum : Enum
        {
            var rightsCode = formEnum.GetFinalName();
            if (CanOpen(rightsCode))
            {
                var f = getFormFunc?.Invoke();
                f?.ShowDialog();
                func?.Invoke(f);
            }
           
        }

        protected void ShowSubForm<TEnum>(TEnum formEnum, Func<Form> getFormFunc, Func<Form, bool> func) where TEnum : Enum
        {
            var rightsCode = formEnum.GetFinalName();
            if (IsPrivateRow() || CanOpen(rightsCode))
            {
                var f = getFormFunc?.Invoke();
                f?.ShowDialog();
                func?.Invoke(f);
            }

        }

        protected void ShowReferenceForm<T>(Func<T, bool> func) where T : Form, new()
        {
            var f = new T();
            f?.ShowDialog();
            func?.Invoke(f);
        }

        protected void ShowReferenceForm<T>(string rightsCode, Func<T, bool> func) where T : Form, new()
        {
            if (CanOpen(rightsCode))
            {
                ShowReferenceForm(func);               
            }
        }

        protected void ShowReferenceForm<T>(ButtonPressedEventArgs e, string rightsCode, Func<T, bool> func) where T : Form, new()
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                ShowReferenceForm<T>(rightsCode, func);
            }
        }

       

        protected void ShowReferenceForm<TEnum>(TEnum formEnum, Func<Form, bool> func) where TEnum : Enum
        {
            var rightsCode = formEnum.GetFinalName();
            if (CanOpen(rightsCode))
            {
                var f = GetForm(formEnum);
                f?.ShowDialog();
                func?.Invoke(f);
            }
        }

        protected void ShowReferenceForm<TEnum, TForm>(TEnum formEnum, Func<TForm, bool> func) 
            where TEnum : Enum
            where TForm : Form
        {
            var rightsCode = formEnum.GetFinalName();
            if (CanOpen(rightsCode))
            {
                var f = GetForm<TEnum, TForm>(formEnum);
                f?.ShowDialog();
                func?.Invoke(f);
            }
        }

        protected void ShowReferenceForm<TEnum, TForm>(ButtonPressedEventArgs e, TEnum formEnum, Func<TForm, bool> func) 
            where TEnum : Enum
            where TForm : Form
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                ShowReferenceForm(formEnum, func);
            }
        }

        protected void ShowReferenceForm<TEnum>(ButtonPressedEventArgs e, TEnum formEnum, Func<Form, bool> func) where TEnum : Enum
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                ShowReferenceForm(formEnum, func);
            }
        }

        protected virtual bool IsPrivateRow()
        {
            return false;
        }

        protected void ShowReferenceForm<TEnum>(TEnum formEnum, Action<Form> prepareAction, Func<Form, bool> func) where TEnum : Enum
        {
            var rightsCode = formEnum.GetFinalName();
            if (CanOpen(rightsCode))
            {
                var f = GuiIoc.GetInstance<Form>(formEnum.ToString());
                prepareAction?.Invoke(f);
                f?.ShowDialog();
                func?.Invoke(f);
            }
        }

        protected void ShowReferenceForm<TEnum, TForm>(TEnum formEnum, Action<TForm> prepareAction, Func<TForm, bool> func) 
            where TEnum : Enum
            where TForm : Form
        {
            var rightsCode = formEnum.GetFinalName();
            if (CanOpen(rightsCode))
            {
                var f = GuiIoc.GetInstance<Form>(formEnum.ToString());
                prepareAction?.Invoke(f as TForm);
                f?.ShowDialog();
                func?.Invoke(f as TForm);
            }
        }

        protected void ShowReferenceForm<TEnum, TForm>(ButtonPressedEventArgs e, TEnum formEnum, Action<TForm> prepareAction, Func<TForm, bool> func)
           where TEnum : Enum
           where TForm : Form
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                ShowReferenceForm(formEnum, prepareAction, func);
            }
        }
    }
}
