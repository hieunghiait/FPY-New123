﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FPY.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HieuNghia\\SQLEXPRESS;Initial Catalog=ManagementReportDB;Integrated Se" +
            "curity=True;TrustServerCertificate=True")]
        public string ManagementReportDBConnectionString {
            get {
                return ((string)(this["ManagementReportDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HieuNghia\\SQLEXPRESS;Initial Catalog=FPY;Integrated Security=True;Enc" +
            "rypt=True;TrustServerCertificate=True")]
        public string FPYConnectionString {
            get {
                return ((string)(this["FPYConnectionString"]));
            }
        }
        //Login_UserName
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Login_UserName
        {
            get
            {
                return ((string)(this["Login_UserName"]));
            }
            set
            {
                this["Login_UserName"] = value;
            }
        }

        //Login_Password
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Login_Password
        {
            get
            {
                return ((string)(this["Login_Password"]));
            }
            set
            {
                this["Login_Password"] = value;
            }
        }
        //Login_IsSaved
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Login_IsSaved
        {
            get
            {
                return ((bool)(this["Login_IsSaved"]));
            }
            set
            {
                this["Login_IsSaved"] = value;
            }
        }
        //ConnectionString
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]

        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HieuNghia\\SQLEXPRESS;Initial Catalog=FPY;Integrated Security=True;Enc" +
                       "rypt=True;TrustServerCertificate=True")]
        public string ConnectionString
        {
            get
            {
                return ((string)(this["ConnectionString"]));
            }
            set
            {
                this["ConnectionString"] = value;
            }
        }
        //Database_ServerName
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HieuNghia\\SQLEXPRESS")]
        public string Database_ServerName
        {
            get
            {
                return ((string)(this["Database_ServerName"]));
            }
            set
            {
                this["Database_ServerName"] = value;
            }
        }
        //Database_ServerCatalog

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FPY")]
        public string Database_ServerCatalog
        {
            get
            {
                return ((string)(this["Database_ServerCatalog"]));
            }
            set
            {
                this["Database_ServerCatalog"] = value;
            }
        }


    }
}
