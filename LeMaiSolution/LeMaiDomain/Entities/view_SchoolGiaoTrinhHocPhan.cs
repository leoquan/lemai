using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SchoolGiaoTrinhHocPhan
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String FK_GiaoTrinh { get; set; }
		public System.String BaiHoc { get; set; }
		public System.String Structure { get; set; }
		public System.String Vocabulary { get; set; }
		public System.String Activities { get; set; }
		public System.String Objectives { get; set; }
		public System.Int32 OrderNumber { get; set; }
		public view_SchoolGiaoTrinhHocPhan(){}
	}
}
