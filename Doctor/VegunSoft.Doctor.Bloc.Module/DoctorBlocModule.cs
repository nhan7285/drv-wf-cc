using VegunSoft.Base.Module.Provider;
using VegunSoft.Doctor.Bloc.Business;
using VegunSoft.Doctor.Bloc.Module.Business;

namespace VegunSoft.Doctor.Bloc.Module
{
    public class DoctorBlocModule : ModUcServiceBase
    {

        public override void Init()
        {
            GuiIoc.RegisterSingleton<IBusinessAdapter, BusinessAdapter>();
            //GuiIoc.Register<IUiServiceMgmt, UiServiceMgmt>();
            //GuiIoc.Register<IGridViewEventService, GridViewEventService>();
        }



    }
}
