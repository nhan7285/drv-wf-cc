using System.Collections.Generic;
using System.Drawing;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.EValue.App;

namespace VegunSoft.Layer.UcService.Provider.App
{
    public class ImageService: IImageService
    {
        private IIocService _guiIoc;
        private IIconService _iconService;
        public ImageService()
        {
            _guiIoc = XIoc.GetService(CGui.IocKey);
            _iconService = _guiIoc.GetInstance<IIconService>();
        }
        private static Dictionary<object, Image> _images = new Dictionary<object, Image>()
        {
            {EGuiImage.Receptionist.ToString(),  Image.FromFile("Images/logo.png")},//global::QlyNhakhoa.Properties.Resources.Rêcptionist
            {EGuiImage.SendMessage.ToString(),  Image.FromFile("Images/send-message.png")}
        };
        public object GetResource(object key)
        {
           
            if (_images.ContainsKey(key))
            {
                return _images[key];
            }

            var rs = _iconService.GetIcon<object>(key?.ToString());
            if (rs != null) return rs;
           
            return null;
        }
       
    }
}
