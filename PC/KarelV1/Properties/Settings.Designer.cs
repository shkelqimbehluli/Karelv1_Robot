﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KarelV1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://lora.localhost/")]
        public string DatabaseUri {
            get {
                return ((string)(this["DatabaseUri"]));
            }
            set {
                this["DatabaseUri"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public double SteppsCount {
            get {
                return ((double)(this["SteppsCount"]));
            }
            set {
                this["SteppsCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        public double StepperPostScaler {
            get {
                return ((double)(this["StepperPostScaler"]));
            }
            set {
                this["StepperPostScaler"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("53.5")]
        public double DiametterOfWheel {
            get {
                return ((double)(this["DiametterOfWheel"]));
            }
            set {
                this["DiametterOfWheel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("149.5")]
        public double DistanceBetweenWheels {
            get {
                return ((double)(this["DistanceBetweenWheels"]));
            }
            set {
                this["DistanceBetweenWheels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("176.33.1.5")]
        public string BrokerHost {
            get {
                return ((string)(this["BrokerHost"]));
            }
            set {
                this["BrokerHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1883")]
        public int BrokerPort {
            get {
                return ((int)(this["BrokerPort"]));
            }
            set {
                this["BrokerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pt/str/i/robot/1")]
        public string MqttInputTopic {
            get {
                return ((string)(this["MqttInputTopic"]));
            }
            set {
                this["MqttInputTopic"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pt/str/o/robot/1")]
        public string MqttOutputTopic {
            get {
                return ((string)(this["MqttOutputTopic"]));
            }
            set {
                this["MqttOutputTopic"] = value;
            }
        }
    }
}
