using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class DynamicFieldType
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String TypeName { get; set; }
		public DynamicFieldType(){}
	}
}
