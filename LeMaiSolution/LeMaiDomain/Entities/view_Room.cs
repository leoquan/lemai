using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_Room
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.String FK_TableGroup { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 Status { get; set; }
		public System.String GroupName { get; set; }
		public System.String GroupId { get; set; }
		public System.String BranchName { get; set; }
		public System.String BranchId { get; set; }
		public view_Room(){}
	}
}
