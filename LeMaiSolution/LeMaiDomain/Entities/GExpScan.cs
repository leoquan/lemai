using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpScan
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Post { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String Note { get; set; }
		public System.String TypeScan { get; set; }
		public System.String BillCode { get; set; }
		public System.String KeyDate { get; set; }
		public System.String UserCreate { get; set; }
		public System.String NameCreate { get; set; }
		public System.Int32? ProblemType { get; set; }
		public System.Boolean IsRead { get; set; }
		public GExpScan(){}
	}
}
