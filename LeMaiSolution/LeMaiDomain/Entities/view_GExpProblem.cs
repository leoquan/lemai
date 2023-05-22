using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_GExpProblem
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime RegisterDate { get; set; }
		public System.String Note { get; set; }
		public System.String UserId { get; set; }
		public System.String FullName { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptManPhone { get; set; }
		public System.String AcceptProvince { get; set; }
		public System.String GoodsName { get; set; }
		public System.String FK_Customer { get; set; }
		public System.Int32 BillStatus { get; set; }
		public System.String RegisterSiteCode { get; set; }
		public System.Decimal BillWeight { get; set; }
		public System.Decimal FeeWeight { get; set; }
		public System.String StatusName { get; set; }
		public System.String StatusBackgroundColor { get; set; }
		public System.String StatusTextColor { get; set; }
		public view_GExpProblem(){}
	}
}
