using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpCommentType
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TypeName { get; set; }
		public ExpCommentType(){}
	}
}
