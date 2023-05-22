using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class TaskIssueTracker
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String TrackerName { get; set; }
		public TaskIssueTracker(){}
	}
}
