using System;
using System.Windows.Forms;
using VegunSoft.App.Config.Provider;
using VegunSoft.App.Data;
using VegunSoft.App.Entity.Provider.Business.Gui;
using VegunSoft.App.Entity.Provider.Business.Log;
using VegunSoft.App.Repository.Business.Cfg;
using VegunSoft.App.Repository.Business.Log;
using VegunSoft.App.Repository.Business.View;
using VegunSoft.App.Service.Mgmt;
using VegunSoft.Base.View.Dev.Forms;
using VegunSoft.Framework.Gui.Provider.WindowsForms;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.App.Widget.Module.Forms
{
    public class FBaseApp : FBase
    {
        protected bool IsDoubleClickEdit => VApp.IsDoubleClickEdit;

        private IRepositoryForm _repositoryForm;
        protected IRepositoryForm RepositoryForm => _repositoryForm ?? (_repositoryForm = DbIoc.GetInstance<IRepositoryForm>());

        private IRepositorySystemConfig _repositorySystemConfig;
        protected IRepositorySystemConfig RepositorySystemConfig => _repositorySystemConfig ?? (_repositorySystemConfig = DbIoc.GetInstance<IRepositorySystemConfig>());

        private IRepositorySystemLog _logRepository;
        protected IRepositorySystemLog LogRepository => _logRepository ?? (_logRepository = DbIoc.GetInstance<IRepositorySystemLog>());



        private MForm _fModel;
        protected MForm FModel => _fModel ?? (_fModel = RepositoryForm.Find(RightsCode));

        protected ISystemState Sys => SApp.Sys;

        private IFormMgmt _formMgmt;
        protected virtual IFormMgmt FormMgmt
        {
            get
            {
                if (_formMgmt == null) _formMgmt = XForm.GetInstance<IFormMgmt>(this);
                return _formMgmt;
            }
        }

        protected void SaveChangesLog(MEntitySystemLog logEntity, bool isSuccess)
        {
            if (isSuccess)
            {
                LogRepository.Save(logEntity);
            }
        }



        protected void RunSaveDbSesion(Control p, Action action)
        {
            Msg?.ClearMessages();
            p.Enabled = false;
            var canRequestDb = FormMgmt.CanRequestDb();
            if (canRequestDb)
            {
                action?.Invoke();
                p.Enabled = true;
            }
            else
            {
                p.Enabled = true;
                Msg.ShowNetworkError();
            }

        }


    }
}
