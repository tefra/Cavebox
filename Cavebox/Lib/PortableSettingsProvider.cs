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
/// 
/// </summary>
public class PortableSettingsProvider : SettingsProvider
{
	/// <summary>
	/// 
	/// </summary>
	const string SETTINGSROOT = "Settings";
	/// <summary>
	/// 
	/// </summary>
	private XmlDocument _settingsXML = null;
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="name"></param>
	/// <param name="col"></param>
	public override void Initialize(string name, NameValueCollection col)
	{
		base.Initialize(this.ApplicationName, col);
	}
	
	/// <summary>
	/// 
	/// </summary>
	public override string ApplicationName
	{
		get { return Application.ProductName; }
		set { }
	}
	
	/// <summary>
	/// 
	/// </summary>
	public override string Name
	{
		get { return "PortableSettingsProvider"; }
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public virtual string GetAppSettingsPath()
	{
		return Path.GetDirectoryName(Application.ExecutablePath);
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public virtual string GetAppSettingsFilename()
	{
		return "settings.xml";
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="context"></param>
	/// <param name="propvals"></param>
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
	/// 
	/// </summary>
	/// <param name="context"></param>
	/// <param name="props"></param>
	/// <returns></returns>
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
	/// 
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
	/// 
	/// </summary>
	/// <param name="setting"></param>
	/// <returns></returns>
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
	/// 
	/// </summary>
	/// <param name="propVal"></param>
	private void SetValue(SettingsPropertyValue propVal)
	{

		XmlElement SettingNode = default(XmlElement);
		
		//Determine if the setting is roaming.
		//If roaming then the value is stored as an element under the root
		//Otherwise it is stored under a machine name node
		try
		{
			SettingNode = (XmlElement)SettingsXML.SelectSingleNode(SETTINGSROOT + "/" + propVal.Name);
		}
		catch
		{
			SettingNode = null;
		}
		
		//Check to see if the node exists, if so then set its new value
		if((SettingNode != null))
		{
			SettingNode.InnerText = propVal.SerializedValue.ToString();
		}
		else
		{
			//Store the value as an element of the Settings Root Node
			SettingNode = SettingsXML.CreateElement(propVal.Name);
			SettingNode.InnerText = propVal.SerializedValue.ToString();
			SettingsXML.SelectSingleNode(SETTINGSROOT).AppendChild(SettingNode);
		}
	}
}