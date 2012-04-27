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
		/// <summary>
		/// 
		/// </summary>
		public static ResourceManager Rm { get; set;}
		
		/// <summary>
		/// 
		/// </summary>
		static Lang()
		{
			Rm = new ResourceManager("Cavebox.Properties.Strings", System.Reflection.Assembly.GetExecutingAssembly());
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string GetString(string str)
		{
			return Rm.GetString(str);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <param name="arg0"></param>
		/// <returns></returns>
		public static string GetString(string str, object arg0)
		{
			return String.Format(GetString(str), arg0);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <returns></returns>
		public static string GetString(string str, object arg0, object arg1)
		{
			return String.Format(GetString(str), arg0, arg1);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str"></param>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
		public static string GetString(string str, object arg0, object arg1, object arg2)
		{
			return String.Format(GetString(str), arg0, arg1, arg2);
		}
	}
}
