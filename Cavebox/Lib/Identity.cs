/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

namespace Cavebox.Lib
{
	/// <summary>
	/// Description of Index.
	/// </summary>
	public class Identity
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="value"></param>
		public Identity(int key, string value)
		{
			Value = value;
			Key = key;
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string Value {get; set;}
		
		/// <summary>
		/// 
		/// </summary>
		public int Key {get; set;}
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Value;
		}
	}
}