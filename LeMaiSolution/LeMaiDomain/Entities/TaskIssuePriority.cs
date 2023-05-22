using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class TaskIssuePriority
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String PriorityName { get; set; }
		public TaskIssuePriority(){}
	}
}
