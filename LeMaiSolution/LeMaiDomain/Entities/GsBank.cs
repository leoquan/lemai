using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsBank
	{
		//Khai bao các biến
		public System.String BankID { get; set; }
		public System.String BankCode { get; set; }
		public System.String BankName { get; set; }
		public System.String BankNameEnglish { get; set; }
		public System.String Address { get; set; }
		public System.String Description { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.String CreatedBy { get; set; }
		public System.DateTime? CreatedDate { get; set; }
		public System.String ModifiedBy { get; set; }
		public System.DateTime? ModifiedDate { get; set; }
		public System.String EBankCode { get; set; }
		public System.String SwiftCode { get; set; }
		public System.String Fk_Region { get; set; }
		public GsBank(){}
	}
}
