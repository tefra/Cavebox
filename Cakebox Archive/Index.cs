/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;

namespace Cakebox_Archive
{
	/// <summary>
	/// Description of Index.
	/// </summary>
	public class Index
	{

	   public Index(int id, string value) 
	   {
	        Value = value;
	        Id = id;
	    }
	
	    public string Value { get; set;}
	
	    public int Id {get; set;}
	    
		override
	    public string ToString()
	    {
	    	return Value;
	    }
	}
}