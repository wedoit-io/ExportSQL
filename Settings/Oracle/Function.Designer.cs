﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExportSQL.Settings.Oracle {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Function : global::System.Configuration.ApplicationSettingsBase {
        
        private static Function defaultInstance = ((Function)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Function())));
        
        public static Function Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("^>>(?<DropStatement>drop function (?<Name>\\w+)) \\|.*?^(?<CreateStatement>create f" +
            "unction .*?as(?<Body>.*?)^END;) \\|\\r\\n")]
        public string Regex {
            get {
                return ((string)(this["Regex"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("create function")]
        public string CreateSearch {
            get {
                return ((string)(this["CreateSearch"]));
            }
            set {
                this["CreateSearch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("create or replace function")]
        public string CreateReplace {
            get {
                return ((string)(this["CreateReplace"]));
            }
            set {
                this["CreateReplace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/")]
        public string CreateEnding {
            get {
                return ((string)(this["CreateEnding"]));
            }
            set {
                this["CreateEnding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(";")]
        public string DropEnding {
            get {
                return ((string)(this["DropEnding"]));
            }
            set {
                this["DropEnding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DropReplace {
            get {
                return ((string)(this["DropReplace"]));
            }
            set {
                this["DropReplace"] = value;
            }
        }
    }
}
