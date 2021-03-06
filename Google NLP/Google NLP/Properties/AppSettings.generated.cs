﻿ 
 

// <autogenerated>
//   This file was generated by T4 code generator AppSettings.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

// ConfigurationProject = Current 
using System;
using System.Configuration;

using Fsmb.Apollo;

namespace GoogleNLPConsole.Properties
{    	
    /// <summary>Provides type-safe access to application settings.</summary>
    /// <remarks>
    /// Each setting in the appSettings section of the config file is generated as a strongly-typed property.  The type
    /// of the property is determined by the value. 
    /// </remarks>
	[System.CodeDom.Compiler.GeneratedCode("AppSettings", "")]
	[System.Diagnostics.DebuggerNonUserCode]
	[System.Diagnostics.DebuggerStepThrough]    
    internal partial class AppSettings : IAppSettings 
    {	
        /// <summary>Gets the default instance.</summary>
        public static AppSettings Default
        {
            get { return s_defaultInstance; }
            protected set { s_defaultInstance = value ?? new AppSettings(); }
        }
	
        protected virtual string GetConfigSetting(string settingName)
        {
            var setting = ConfigurationManager.AppSettings[settingName];
            return setting ?? "";
        }		

        protected Guid ToGuidOrDefault ( string value )
        {
            Guid result;

            if (Guid.TryParse(value, out result))
                return result;

            return Guid.Empty;
        }		

        private static AppSettings s_defaultInstance = new AppSettings();
    }

    /// <summary>Represents the application settings.</summary>
	[System.CodeDom.Compiler.GeneratedCode("AppSettings", "")]    
    internal interface IAppSettings
    {
    }
}