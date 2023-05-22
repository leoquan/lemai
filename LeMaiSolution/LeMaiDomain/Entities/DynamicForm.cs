using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class DynamicForm
	{
		//Khai bao các biến
		public System.String FormName { get; set; }
		public System.DateTime CreateDate { get; set; }
		public DynamicForm(){}
	}
}
