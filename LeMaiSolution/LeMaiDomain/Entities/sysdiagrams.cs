using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class sysdiagrams
	{
		//Khai bao các biến
		public System.String name { get; set; }
		public System.Int32 principal_id { get; set; }
		public System.Int32 diagram_id { get; set; }
		public System.Int32? version { get; set; }
		public System.Byte[] definition { get; set; }
		public sysdiagrams(){}
	}
}
