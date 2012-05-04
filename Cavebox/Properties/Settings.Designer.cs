﻿/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox.Properties {
	
	
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "4.2.0.8774")]
	internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
		
		private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
		
		public static Settings Default {
			get {
				return defaultInstance;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool AlwaysOnTop {
			get {
				return ((bool)(this["AlwaysOnTop"]));
			}
			set {
				this["AlwaysOnTop"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("258")]
		public int CakeboxDiscSplitterDistance {
			get {
				return ((int)(this["CakeboxDiscSplitterDistance"]));
			}
			set {
				this["CakeboxDiscSplitterDistance"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("310")]
		public int FileListSplitterDistance {
			get {
				return ((int)(this["FileListSplitterDistance"]));
			}
			set {
				this["FileListSplitterDistance"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
		public string LastScanPath {
			get {
				return ((string)(this["LastScanPath"]));
			}
			set {
				this["LastScanPath"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("0")]
		public int SelectedTabIndex {
			get {
				return ((int)(this["SelectedTabIndex"]));
			}
			set {
				this["SelectedTabIndex"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
		public global::System.Drawing.Point WindowLocation {
			get {
				return ((global::System.Drawing.Point)(this["WindowLocation"]));
			}
			set {
				this["WindowLocation"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("550, 600")]
		public global::System.Drawing.Size WindowSize {
			get {
				return ((global::System.Drawing.Size)(this["WindowSize"]));
			}
			set {
				this["WindowSize"] = value;
			}
		}
	}
}
