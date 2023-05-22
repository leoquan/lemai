using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_Service
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String Name { get; set; }
		public System.Int32 Price { get; set; }
		public System.Int32? PriceMotion { get; set; }
		public System.String FK_Group { get; set; }
		public System.String FK_Branch { get; set; }
		public System.Boolean IsPublicBranch { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public System.Boolean IsService { get; set; }
		public System.String UnitName { get; set; }
		public System.String Barcode { get; set; }
		public System.String ImagePath { get; set; }
		public System.String ShortDescription { get; set; }
		public System.String Description { get; set; }
		public System.String ContentBody { get; set; }
		public System.Boolean IsBooking { get; set; }
		public System.Boolean IsCombo { get; set; }
		public System.DateTime ValidDate { get; set; }
		public System.DateTime ExpriedDate { get; set; }
		public System.Int32? InventoryCount { get; set; }
		public System.String TradeMark { get; set; }
		public System.Boolean IsDelete { get; set; }
		public System.Int32 PercentComission { get; set; }
		public System.Boolean IsDynamicPrice { get; set; }
		public System.Boolean IsShowOnWeb { get; set; }
		public System.String Unsign { get; set; }
		public System.Double? Rating { get; set; }
		public System.String ShortUnsign { get; set; }
		public System.Byte[] AtRowVersion { get; set; }
		public System.String Icon { get; set; }
		public System.String GroupName { get; set; }
		public System.String GroupId { get; set; }
		public System.Boolean IsDeleteGroup { get; set; }
		public System.String BranchName { get; set; }
		public System.String BranchId { get; set; }
		public System.String CreateByName { get; set; }
		public view_Service(){}
	}
}
