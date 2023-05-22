using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsRequestFindProductHistory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_RequestFindProduct { get; set; }
		public System.String FK_UserProcess { get; set; }
		public System.String ProcessNote { get; set; }
		public System.DateTime ProcessDate { get; set; }
		public System.String ProcessType { get; set; }
		public GsRequestFindProductHistory(){}
	}
}
