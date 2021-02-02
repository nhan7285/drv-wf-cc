using System.ComponentModel;
using VegunSoft.Framework.Gui.Services;

namespace VegunSoft.App.Icon
{
    public class IconService: IIconService
    {
        private ComponentResourceManager[] _resources;
        protected ComponentResourceManager[] Resources => _resources ?? (_resources = new ComponentResourceManager[]
        {
            new ComponentResourceManager(typeof(IconExplorerForm))
        });

        private ComponentResourceManager[] _resources16;
        protected ComponentResourceManager[] Resources16 => _resources16 ?? (_resources16 = new ComponentResourceManager[]
        {
            new ComponentResourceManager(typeof(IconExplorerForm16))
        });

        private ComponentResourceManager[] _resources24;
        protected ComponentResourceManager[] Resources24 => _resources24 ?? (_resources24 = new ComponentResourceManager[]
        {
            new ComponentResourceManager(typeof(IconExplorerForm24))
        });

        private ComponentResourceManager[] _resources32;
        protected ComponentResourceManager[] Resources32 => _resources32 ?? (_resources32 = new ComponentResourceManager[]
        {
            new ComponentResourceManager(typeof(IconExplorerForm32)),
            new ComponentResourceManager(typeof(FIconCategory32)),
            new ComponentResourceManager(typeof(FIconSchedule32)),
        });

        private ComponentResourceManager[] _resources64;
        protected ComponentResourceManager[] Resources64 => _resources64 ?? (_resources64 = new ComponentResourceManager[]
        {
            new ComponentResourceManager(typeof(IconExplorerForm64))
        });

        private ComponentResourceManager[] _resources128;
        protected ComponentResourceManager[] Resources128 => _resources128 ?? (_resources128 = new ComponentResourceManager[] 
        {
            new ComponentResourceManager(typeof(IconExplorerForm128)),
            new ComponentResourceManager(typeof(FIconCategory128)),
            new ComponentResourceManager(typeof(FIconSchedule128)),
        });


        public T GetIcon<T>(ComponentResourceManager[] resources, string key) where T : class
        {
            foreach (var r in resources)
            {
                try
                {
                    var rs = r.GetObject(key) as T;
                    if (rs != null) return rs;
                }
                catch (System.Exception)
                {
                    continue;
                }

            }
            return default(T);
        }

        #region Any

        public T GetIcon<T>(string key) where T: class
        {
            return GetIcon<T>(Resources, key);
        }

        public T GetIcon<TEnum, T>(TEnum key, string surfix = ".Image") where T : class
        {
            return GetIcon<T>($"{key}{surfix}") ?? GetIcon<T>($"{key}.ImageOptions.Image");
        }

        #endregion

        #region 16

        public T GetIcon16<T>(string key) where T : class
        {
            return GetIcon<T>(Resources16, key);
        }

        public T GetIcon16<TEnum, T>(TEnum key, string surfix = ".Image") where T : class
        {
            return GetIcon16<T>($"{key}{surfix}") ?? GetIcon16<T>($"{key}.ImageOptions.Image");
        }

        #endregion

        #region 24

        public T GetIcon24<T>(string key) where T : class
        {
            return GetIcon<T>(Resources24, key);
        }

        public T GetIcon24<TEnum, T>(TEnum key, string surfix = ".Image") where T : class
        {
            return GetIcon24<T>($"{key}{surfix}") ?? GetIcon24<T>($"{key}.ImageOptions.Image");
        }

        #endregion

        #region 32

        public T GetIcon32<T>(string key) where T : class
        {
            return GetIcon<T>(Resources32, key);
        }

        public T GetIcon32<TEnum, T>(TEnum key, string surfix = ".Image") where T : class
        {
            return GetIcon32<T>($"{key}{surfix}") ?? GetIcon32<T>($"{key}.ImageOptions.Image");
        }

        #endregion

        #region 64

        public T GetIcon64<T>(string key) where T : class
        {
            return GetIcon<T>(Resources64, key);
        }

        public T GetIcon64<TEnum, T>(TEnum key, string surfix = ".Image") where T : class
        {
            return GetIcon64<T>($"{key}{surfix}") ?? GetIcon64<T>($"{key}.ImageOptions.Image");
        }

        #endregion


        #region 128

        public T GetIcon128<T>(string key) where T : class
        {
            return GetIcon<T>(Resources128, key);
        }

        public T GetIcon128<TEnum, T>(TEnum key, string surfix = ".Image") where T : class
        {
            return GetIcon128<T>($"{key}{surfix}") ?? GetIcon128<T>($"{key}.ImageOptions.Image");
        }

        #endregion
    }
}
