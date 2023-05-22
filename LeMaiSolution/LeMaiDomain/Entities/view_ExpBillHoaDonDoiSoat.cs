using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpBillHoaDonDoiSoat
	{
		//Khai bao các biến
		public System.DateTime CreateHd { get; set; }
		public System.String FK_Post { get; set; }
		public System.String HoaDon { get; set; }
		public System.String FK_Account { get; set; }
		public System.String GiaoThanhCong { get; set; }
		public System.String BILL_CODE { get; set; }
		public System.Decimal? BILL_WEIGHT { get; set; }
		public System.Decimal? FEE_WEIGHT { get; set; }
		public System.String SEND_SITE_CODE { get; set; }
		public System.String REGISTER_SITE_CODE { get; set; }
		public System.Decimal FREIGHT { get; set; }
		public System.Decimal GOODS_PAYMENT { get; set; }
		public System.String SEND_MAN { get; set; }
		public System.String SEND_MAN_PHONE { get; set; }
		public System.String SEND_MAN_ADDRESS { get; set; }
		public System.String ACCEPT_MAN { get; set; }
		public System.String ACCEPT_MAN_PHONE { get; set; }
		public System.String ACCEPT_MAN_ADDRESS { get; set; }
		public System.String ACCEPT_PROVINCE_CODE { get; set; }
		public System.String ACCEPT_CITY_CODE { get; set; }
		public System.String ACCEPT_COUNTY_CODE { get; set; }
		public System.Boolean IS_SIGNED { get; set; }
		public System.Boolean IS_RETURN { get; set; }
		public System.Int32 BILL_PROCESS_STATUS { get; set; }
		public System.String FK_Customer { get; set; }
		public System.DateTime REGISTER_DATE { get; set; }
		public System.DateTime? SIGNED_DATE { get; set; }
		public System.DateTime LAST_UPDATE_DATE { get; set; }
		public System.String LAST_UPDATE_USER { get; set; }
		public System.String PAY_TYPE { get; set; }
		public System.Decimal? TTKT_WEIGHT { get; set; }
		public System.String LAST_POST { get; set; }
		public System.Boolean? IS_VITURAL { get; set; }
		public System.String DES_SITE { get; set; }
		public System.String Note { get; set; }
		public System.Int32 WORKING_PRIOTY { get; set; }
		public System.DateTime SYSTEM_DATE { get; set; }
		public System.String BT3Type { get; set; }
		public System.String BT3Code { get; set; }
		public System.String BT3Status { get; set; }
		public System.String BT3LastMess { get; set; }
		public System.String CustomerCode { get; set; }
		public System.String CustomerName { get; set; }
		public System.DateTime? NgayHopDong { get; set; }
		public System.String TenHopDong { get; set; }
		public System.Boolean ContractCustomer { get; set; }
		public System.Int32? STT { get; set; }
		public System.String SUM_ADDRESS { get; set; }
		public view_ExpBillHoaDonDoiSoat(){}
	}
}
