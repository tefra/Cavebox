/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Resources;

namespace Cavebox.Lib
{
	/// <summary>
	/// Lazy load of the custom strings resource
	/// </summary>
	public class Lang
	{
		/// <summary>
		/// Magic get set ResourceManager
		/// </summary>
		public static ResourceManager Rm { get; set;}
		
		/// <summary>
		/// Initialize ResourceManager Rm
		/// </summary>
		static Lang()
		{
			Rm = new ResourceManager("Cavebox.Properties.Strings", System.Reflection.Assembly.GetExecutingAssembly());
		}
		
		/// <summary>
		/// Get string from the ResourceManager
		/// </summary>
		/// <param name="str">Phrase key</param>
		/// <returns>Phrase text</returns>
		public static string GetString(string str)
		{
			return Rm.GetString(str);
		}
		
		/// <summary>
		/// Get string from the ResourceManager and format with one argument
		/// </summary>
		/// <param name="str">Phrase key</param>
		/// <param name="arg0">Param to string format</param>
		/// <returns>Phrase text</returns>
		public static string GetString(string str, object arg0)
		{
			return String.Format(GetString(str), arg0);
		}
		
		/// <summary>
		/// Get string from the ResourceManager and format with two argument
		/// </summary>
		/// <param name="str">Phrase key</param>
		/// <param name="arg0">Param to string format</param>
		/// <param name="arg1">Param to string format</param>
		/// <returns>Phrase text</returns>
		public static string GetString(string str, object arg0, object arg1)
		{
			return String.Format(GetString(str), arg0, arg1);
		}
		
		/// <summary>
		/// Get string from the ResourceManager and format with three argument
		/// </summary>
		/// <param name="str">Phrase key</param>
		/// <param name="arg0">Param to string format</param>
		/// <param name="arg1">Param to string format</param>
		/// <param name="arg2">Param to string format</param>
		/// <returns>Phrase text</returns>
		public static string GetString(string str, object arg0, object arg1, object arg2)
		{
			return String.Format(GetString(str), arg0, arg1, arg2);
		}
	}
}
