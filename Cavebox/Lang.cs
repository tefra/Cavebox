/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Resources;

namespace Cavebox
{
	/// <summary>
	/// Description of Lang.
	/// </summary>
	public class Lang
	{
		public static ResourceManager Rm { get; set;}
		
		static Lang()
		{
			Rm = new ResourceManager("Cavebox.Properties.Strings", System.Reflection.Assembly.GetExecutingAssembly());
		}
		
		public static string GetString(string str)
		{
			return Rm.GetString(str);
		}
		
		public static string GetString(string str, object arg0)
		{
			return String.Format(GetString(str), arg0);
		}
		
		public static string GetString(string str, object arg0, object arg1)
		{
			return String.Format(GetString(str), arg0, arg1);
		}
		
		public static string GetString(string str, object arg0, object arg1, object arg2)
		{
			return String.Format(GetString(str), arg0, arg1, arg2);
		}
	}
}
