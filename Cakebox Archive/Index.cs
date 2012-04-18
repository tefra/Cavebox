/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 14/4/2012
 * Time: 2:55 πμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
