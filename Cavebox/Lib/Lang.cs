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
	static class Lang
	{
		/// <summary>
		/// Magic get set ResourceManager
		/// </summary>
		public static ResourceManager Rm { get; set; }
		
		/// <summary>
		/// Initialize ResourceManager Rm
		/// </summary>
		static Lang()
		{
			Rm = new ResourceManager("Cavebox.Properties.Strings", System.Reflection.Assembly.GetExecutingAssembly());
		}
		
		/// <summary>
		/// Get a string by key from the resources and format text if args is not empty
		/// </summary>
		/// <param name="str">The phrase key</param>
		/// <param name="args">Arguments to format text</param>
		public static string GetString(string str, params object[] args)
		{
			return (args.Length == 0) ? Rm.GetString(str) : String.Format(Rm.GetString(str), args);
		}
	}
}