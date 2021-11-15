using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VegunSoft.Framework.Gui;
using VegunSoft.Framework.Gui.Enums;
using VegunSoft.Framework.Ioc;
using VegunSoft.Framework.Ioc.Apis;
using VegunSoft.Framework.Ioc.Enums;
using VegunSoft.Framework.Module.Modules;

namespace VegunSoft.Base.View.Dev
{
    public abstract class GuiModule : LeafModule
    {
        private IIocService _guiIoc;
        protected IIocService GuiIoc => _guiIoc ?? (_guiIoc = XIoc.GetService(CGui.IocKey));
        protected static string ImgSvcKey { get; } = EGuiService.SizedImageService.ToString();

        #region Virtual

        protected virtual IDictionary<Type, Type> RawTransientForms { get; }

        protected virtual IDictionary<Type, Type> RawSingletonForms { get; }

        protected virtual IDictionary<object, Type> KeyTransientForms { get; }

        protected virtual IDictionary<object, Type> KeySingletonForms { get; }

        public virtual void Register()
        {

        }

        public virtual void InitViews()
        {

        }

        #endregion

        #region override

        public override void Init()
        {
            Register();
            RegisterAuto();
            InitViews();
           
         
        }

        public override void Run()
        {

        }

        public override void Exit()
        {

        }
        #endregion

        #region Menu

       

     

       

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
