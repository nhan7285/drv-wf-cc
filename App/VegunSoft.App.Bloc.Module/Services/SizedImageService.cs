using System.Collections.Generic;
using System.Drawing;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums.Image;
using VegunSoft.Framework.Gui.Services;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Layer.EValue.App;

namespace VegunSoft.Layer.UcService.Provider.App
{
    public class SizedImageService : IImageService
    {
        private IIocService _guiIoc;
        private IIconService _iconService;
        public SizedImageService()
        {
            _guiIoc = XIoc.GetService(CGui.IocKey);
            _iconService = _guiIoc.GetInstance<IIconService>();
        }
        private static Dictionary<object, Image> _images = new Dictionary<object, Image>()
        {
            {EGuiImage.Receptionist.ToString(), Image.FromFile("Images/logo.png") },//global::QlyNhakhoa.Properties.Resources.Rêcptionist
            {EGuiImage.SendMessage.ToString(),  Image.FromFile("Images/send-message.png")}
        };
        public object GetResource(object key)
        {
            if (key is EResourceImage16 k16)
            {
                return GetResource(k16);
            }

            if (key is EResourceImage24 k24)
            {
                return GetResource(k24);
            }

            if (key is EResourceImage32 k32)
            {
                return GetResource(k32);
            }

            if (key is EResourceImage64 k64)
            {
                return GetResource(k64);
            }

            if (key is EResourceImage128 k128)
            {
                return GetResource(k128);
            }

            if (_images.ContainsKey(key))
            {
                return _images[key];
            }

         
            return null;
        }

        public object GetResource(EResourceImage16 key)
        {
            var rs = _iconService.GetIcon16<EResourceImage16, Image>(key);
            return rs;
        }

        public object GetResource(EResourceImage24 key)
        {
            var rs = _iconService.GetIcon24<EResourceImage24, Image>(key);
            return rs;
        }

        public object GetResource(EResourceImage32 key)
        {
            var rs = _iconService.GetIcon32<EResourceImage32, Image>(key);
            return rs;
        }

        public object GetResource(EResourceImage64 key)
        {
            var rs = _iconService.GetIcon32<EResourceImage64, Image>(key);
            return rs;
        }

        public object GetResource(EResourceImage128 key)
        {
            var rs = _iconService.GetIcon32<EResourceImage128, Image>(key);
            return rs;
        }
    }
}
