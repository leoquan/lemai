using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpProblem
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime RegisterDate { get; set; }
		public System.String Note { get; set; }
		public System.String UserId { get; set; }
		public System.String FullName { get; set; }
		public GExpProblem(){}
	}
}
