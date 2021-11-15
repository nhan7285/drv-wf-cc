namespace VegunSoft.Layer.UcService.Services.App
{
    public interface IAppService<T>
    {
        IAppService<T> Init(T instance);

        IAppService<T> UpdateTitle();

        IAppService<T> SwitchMode();
    }
}
