using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpPhatHanhChungTu
	{
		//Khai bao các biến
		public System.String BILL_CODE { get; set; }
		public System.String FK_ChungTuCT { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_CreateBy { get; set; }
		public ExpPhatHanhChungTu(){}
	}
}
