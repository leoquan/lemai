using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class TaskIssue
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Title { get; set; }
		public System.String ContentBody { get; set; }
		public System.Int32 FK_Status { get; set; }
		public System.Int32 FK_Tracker { get; set; }
		public System.Int32 FK_Priority { get; set; }
		public System.String FK_Assignee { get; set; }
		public System.DateTime? StartDate { get; set; }
		public System.DateTime? EndDate { get; set; }
		public System.Int32 PercentComplete { get; set; }
		public System.String FileAttach { get; set; }
		public System.String FK_Branch { get; set; }
		public System.Boolean IsPrivate { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.String CreateBy { get; set; }
		public TaskIssue(){}
	}
}
