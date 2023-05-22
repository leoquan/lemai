using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsCategory
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Code { get; set; }
		public System.String CategoryName { get; set; }
		public System.String Slug_Name { get; set; }
		public System.Boolean AutoSlug { get; set; }
		public System.String FK_CategoryId { get; set; }
		public System.Int32 RankIndex { get; set; }
		public System.Int32 SortIndex { get; set; }
		public System.String Tags { get; set; }
		public System.String KeyWord { get; set; }
		public System.String MetaData { get; set; }
		public System.String Note { get; set; }
		public System.String CreatedBy { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public System.String UpdatedBy { get; set; }
		public System.DateTime? UpdatedDate { get; set; }
		public System.Int32 RowStatus { get; set; }
		public System.Int32 CountChild { get; set; }
		public System.Int32 CountProduct { get; set; }
		public GsCategory(){}
	}
}
