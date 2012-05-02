/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

namespace Cavebox.Lib
{
	/// <summary>
	///  Custom KeyValuePair to avoid all this List<keyvaluepair<int, string>> gibberish
	/// </summary>
	public class Identity
	{
		/// <summary>
		/// Construct my lazy gibberish
		/// </summary>
		/// <param name="id"></param>
		/// <param name="value"></param>
		public Identity(int key, string value)
		{
			Value = value;
			Key = key;
		}
		
		/// <summary>
		/// Magic get set Value
		/// </summary>
		public string Value {get; set;}
		
		/// <summary>
		/// Magic get set Key
		/// </summary>
		public int Key {get; set;}
		
		/// <summary>
		/// Return the Value of the identity
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Value;
		}
	}
}