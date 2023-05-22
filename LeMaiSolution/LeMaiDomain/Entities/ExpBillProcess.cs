using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpBillProcess
	{
		//Khai bao các biến
		public System.String Bill_Code { get; set; }
		public System.Int32 Type { get; set; }
		public System.DateTime DateCreate { get; set; }
		public System.Int32 Value { get; set; }
		public ExpBillProcess(){}
	}
}
