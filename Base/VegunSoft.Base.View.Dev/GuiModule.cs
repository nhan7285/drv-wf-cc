using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Gui.Models.Bar;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Ioc.Enums;
using VegunSoft.Framework.Module.Modules;
using VegunSoft.Layer.Model.Gui;
using VegunSoft.Layer.Model.Provider.Module;

namespace VegunSoft.Base.View.Dev
{
    public abstract class GuiModule : LeafModule
    {
        private IIocService _guiIoc;
        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));
        protected static string ImgSvcKey { get; } = EGuiService.SizedImageService.ToString();

        #region Virtual

        protected virtual IEnumerable<MShowModule> Modules { get; }

        protected virtual IEnumerable<MBarButtonItem> MenuItems { get; }

        protected virtual IEnumerable<MRibbonPage> MenuGroups { get; }

        protected virtual IDictionary<Type, Type> RawTransientForms { get; }

        protected virtual IDictionary<Type, Type> RawSingletonForms { get; }

        protected virtual IDictionary<object, Type> KeyTransientForms { get; }

        protected virtual IDictionary<object, Type> KeySingletonForms { get; }

        public virtual void Register()
        {

        }

        #endregion

        #region override

        public override void Init()
        {
            Register();
            RegisterAuto();
            InitModules(Modules);
            InitMenuGroups(MenuGroups);
            InitMenuItems(MenuItems);
        }

        public override void Run()
        {

        }

        public override void Exit()
        {

        }
        #endregion

        #region Menu

        protected void InitModules(IEnumerable<MShowModule> items)
        {
            if (items == null) return;
            if (((items?.Count()) ?? 0) <= 0) return;
            var list = DView.Modules;
            foreach (var item in items)
            {
                if (!list.Any(x => x.Key == item.Key)) list.Add(item);
            }
        }

        protected void InitMenuItems(IEnumerable<MBarButtonItem> items)
        {
            if (items == null) return;
            if (items?.Count() <= 0) return;
            var imgSvc = EGuiService.SizedImageService.ToString();
            var list = DView.MenuItems;
            foreach (var item in items)
            {
                if (item is IAutoBarButtonItem autoItem)
                {
                    autoItem.ServiceKey = imgSvc;
                    autoItem.Init();
                }

                list.Add(item);
            }
        }

        protected void InitMenuGroups(IEnumerable<MRibbonPage> items)
        {
            if(items == null) return;
            if (items.Count() <= 0) return;
            var list = DView.MenuGroups;
            foreach (var item in items)
            {
                if (!list.Any(x => x.Name == item.Name)) list.Add(item);
            }
        }

        #endregion

        #region Register

        protected virtual void Register<T1, T2>()
         where T1 : class
         where T2 : class, T1
        {
            GuiIoc.Register<T1, T2>();
        }

        protected virtual void Register<T1, T2>(string key)
            where T1 : class
            where T2 : class, T1
        {
            GuiIoc.Register<T1, T2>(key);
        }

        protected virtual void RegisterForm<T>(object key)
          where T : Form
        {
            GuiIoc.Register<Form, T>(key?.ToString());
        }

        protected virtual void RegisterFormTransient(Type type1, Type type2)
        {
            GuiIoc.Register(type1, type2, ELifestyle.Transient);
        }

        protected virtual void RegisterFormSingleton(Type type1, Type type2)
        {
            GuiIoc.Register(type1, type2, ELifestyle.Singleton);
        }

        protected virtual void RegisterKeyFormTransient(Type type, object key)
        {
            GuiIoc.Register(typeof(Form), type, ELifestyle.Transient, key?.ToString());
        }

        protected virtual void RegisterKeyFormSingleton(Type type, object key)
        {
            GuiIoc.Register(typeof(Form), type, ELifestyle.Singleton, key?.ToString());
        }

        private void RegisterAuto()
        {
            if (RawTransientForms?.Count > 0)
            {
                foreach (var kv in RawTransientForms)
                {
                    var type1 = kv.Key;
                    var type2 = kv.Value;
                    RegisterFormTransient(type1, type2);
                }
            }
            if (RawSingletonForms?.Count > 0)
            {
                foreach (var kv in RawSingletonForms)
                {
                    var type1 = kv.Key;
                    var type2 = kv.Value;
                    RegisterFormSingleton(type1, type2);
                }
            }
            if (KeyTransientForms?.Count > 0)
            {
                foreach (var kv in KeyTransientForms)
                {
                    var type = kv.Value;
                    RegisterKeyFormTransient(type, kv.Key);
                }
            }
            if (KeySingletonForms?.Count > 0)
            {
                foreach (var kv in KeySingletonForms)
                {
                    var type = kv.Value;
                    RegisterKeyFormSingleton(type, kv.Key);
                }
            }
        }

        protected virtual void RegisterFormSingleton<T>(object key)
          where T : Form
        {
            GuiIoc.RegisterSingleton<Form, T>(key?.ToString());
        }

        protected virtual void RegisterSingleton<T1, T2>(string key)
           where T1 : class
           where T2 : class, T1
        {
            GuiIoc.RegisterSingleton<T1, T2>(key);
        }

        protected virtual void RegisterSingleton<T1, T2>()
          where T1 : class
          where T2 : class, T1
        {
            GuiIoc.RegisterSingleton<T1, T2>();
        }
        #endregion

    }
}
