using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_SchoolRoom
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenPhong { get; set; }
		public System.String FK_TrungTam { get; set; }
		public System.String TrungTam { get; set; }
		public view_SchoolRoom(){}
	}
}
