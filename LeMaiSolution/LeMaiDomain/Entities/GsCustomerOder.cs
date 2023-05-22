using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsCustomerOder
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String AccountObjecID { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String FK_Department { get; set; }
		public System.String FK_ACEmployee { get; set; }
		public System.String FK_CustomerSource { get; set; }
		public System.String FK_DataChanel { get; set; }
		public System.String CustomerName { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String CustomerAdd { get; set; }
		public System.String FK_Contry { get; set; }
		public System.String FK_CompanyType { get; set; }
		public System.String Website { get; set; }
		public System.String Phone { get; set; }
		public System.String ContactName { get; set; }
		public System.String ContactPosition { get; set; }
		public System.String ContactMobile { get; set; }
		public System.String MessengerChat { get; set; }
		public System.String ImportFrom { get; set; }
		public System.String ExportTo { get; set; }
		public System.String ProductName { get; set; }
		public System.String ProductDescription { get; set; }
		public System.Int32? Quantity { get; set; }
		public System.String DeliveryCondition { get; set; }
		public GsCustomerOder(){}
	}
}
