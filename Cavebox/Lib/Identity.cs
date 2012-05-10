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
		/// We don't really need this but that stupid checklistbox doesn't support databinding so
		/// we must add this to display propertly the list's display member
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Value;
		}
	}
}