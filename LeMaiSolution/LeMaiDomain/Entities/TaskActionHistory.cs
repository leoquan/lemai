using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class TaskActionHistory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.DateTime ActionDate { get; set; }
		public System.String ContentAction { get; set; }
		public System.String FK_AcctionBy { get; set; }
		public System.String FK_TaskIssue { get; set; }
		public TaskActionHistory(){}
	}
}
