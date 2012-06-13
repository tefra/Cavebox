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
		/// <param name="id">Integer key</param>
		/// <param name="value">String value</param>
		public Identity(int key, string value)
		{
			Value = value;
			Key = key;
		}
		
		/// <summary>
		/// Magic get set Value
		/// </summary>
		public string Value { get; set; }
		
		/// <summary>
		/// Magic get set Key
		/// </summary>
		public int Key { get; set; }
		
		/// <summary>
		/// We don't really need this but that stupid checklistbox doesn't support databinding so
		/// we must add this to display properly the list's display member
		/// </summary>
		public override string ToString()
		{
			return Value;
		}
	}
}