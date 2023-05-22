using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpComment
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String BillCode { get; set; }
		public System.DateTime UpdateDate { get; set; }
		public System.String Comment { get; set; }
		public System.String Author { get; set; }
		public System.String CommentType { get; set; }
		public System.String TypeName { get; set; }
		public System.String FullName { get; set; }
		public view_ExpComment(){}
	}
}
