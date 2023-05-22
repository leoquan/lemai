using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class DynamicField
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FieldName { get; set; }
		public System.Int32 FK_FieldType { get; set; }
		public DynamicField(){}
	}
}
