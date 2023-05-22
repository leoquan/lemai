using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpBILL
	{
		//Khai bao các biến
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
		public System.String StatusName { get; set; }
		public view_ExpBILL(){}
	}
}
