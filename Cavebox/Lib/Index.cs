/**
 * @version	$Id: Index.cs 68 2012-04-23 22:59:36Z Tefra $
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

namespace Cavebox.Lib
{
	/// <summary>
	/// Description of Index.
	/// </summary>
	public class Index
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="value"></param>
		public Index(int id, string value)
		{
			Value = value;
			Id = id;
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string Value {get; set;}
		
		/// <summary>
		/// 
		/// </summary>
		public int Id {get; set;}
		
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