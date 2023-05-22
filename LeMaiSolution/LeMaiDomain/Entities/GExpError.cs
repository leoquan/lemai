using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpError
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ErrorName { get; set; }
		public System.String Provider { get; set; }
		public System.String BillCode { get; set; }
		public System.String BT3Code { get; set; }
		public System.String Note { get; set; }
		public GExpError(){}
	}
}
