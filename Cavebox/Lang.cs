/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 20/4/2012
 * Time: 12:07 πμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
