/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Xml;
using System.IO;

/// <summary>
/// Custom settings provider
/// Stores the settings inside the application execution path in xml format
/// The xml is named Settings.xml
/// </summary>
public class PortableSettingsProvider : SettingsProvider
{
	const string SETTINGSROOT = "Settings";
	private XmlDocument _settingsXML = null;
	
	/// <summary>
	/// Initializes the provider
	/// </summary>
	public override void Initialize(string name, NameValueCollection col)
	{
		base.Initialize(this.ApplicationName, col);
	}
	
	/// <summary>
	/// Magic get set for the application name
	/// </summary>
	public override string ApplicationName
	{
		get { return Application.ProductName; }
		set { }
	}
	
	/// <summary>
	/// Magic get for the Provider name
	/// </summary>
	public override string Name
	{
		get { return "PortableSettingsProvider"; }
	}
	
	/// <summary>
	/// Return the application execution path
	/// </summary>
	public virtual string GetAppSettingsPath()
	{
		return Path.GetDirectoryName(Application.ExecutablePath);
	}
	
	/// <summary>
	/// Get the filename where we are going to store/read the settings
	/// </summary>
	public virtual string GetAppSettingsFilename()
	{
		return "settings.xml";
	}
	
	/// <summary>
	/// Set property values
	/// </summary>
	public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection propvals)
	{
		foreach (SettingsPropertyValue propval in propvals)
		{
			SetValue(propval);
		}
		try
		{
			SettingsXML.Save(Path.Combine(GetAppSettingsPath(), GetAppSettingsFilename()));
		}
		catch { }
	}
	
	/// <summary>
	/// Returns the collection of properties values for the specified application and instance and settings property group
	/// </summary>
	public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection props)
	{
		SettingsPropertyValueCollection values = new SettingsPropertyValueCollection();
		foreach (SettingsProperty setting in props)
		{
			SettingsPropertyValue value = new SettingsPropertyValue(setting);
			value.IsDirty = false;
			value.SerializedValue = GetValue(setting);
			values.Add(value);
		}
		return values;
	}
	
	/// <summary>
	/// Retrieve/Load/Create xml documnt
	/// </summary>
	private XmlDocument SettingsXML
	{
		get {
			if (_settingsXML == null)
			{
				_settingsXML = new XmlDocument();
				try
				{
					_settingsXML.Load(Path.Combine(GetAppSettingsPath(), GetAppSettingsFilename()));
				}
				catch
				{
					XmlDeclaration dec = _settingsXML.CreateXmlDeclaration("1.0", "utf-8", string.Empty);
					_settingsXML.AppendChild(dec);
					XmlNode nodeRoot = default(XmlNode);
					nodeRoot = _settingsXML.CreateNode(XmlNodeType.Element, SETTINGSROOT, "");
					_settingsXML.AppendChild(nodeRoot);
				}
			}
			
			return _settingsXML;
		}
	}
	
	/// <summary>
	/// Get the value of a named setting
	/// </summary>
	private string GetValue(SettingsProperty setting)
	{
		try
		{
			return SettingsXML.SelectSingleNode(SETTINGSROOT + "/" + setting.Name).InnerText;
		}
		catch
		{
			return (setting.DefaultValue != null) ? setting.DefaultValue.ToString() : "";
		}
	}
	
	/// <summary>
	/// Check to see if the node exists, if so then set its new value
	/// Otherwise store the value as an element of the Settings Root Node
	/// </summary>
	private void SetValue(SettingsPropertyValue propVal)
	{
		XmlElement SettingNode = default(XmlElement);
		try
		{
			SettingNode = (XmlElement) SettingsXML.SelectSingleNode(SETTINGSROOT + "/" + propVal.Name);
		}
		catch
		{
			SettingNode = null;
		}

		if((SettingNode != null))
		{
			SettingNode.InnerText = propVal.SerializedValue.ToString();
		}
		else
		{
			SettingNode = SettingsXML.CreateElement(propVal.Name);
			SettingNode.InnerText = propVal.SerializedValue.ToString();
			SettingsXML.SelectSingleNode(SETTINGSROOT).AppendChild(SettingNode);
		}
	}
}