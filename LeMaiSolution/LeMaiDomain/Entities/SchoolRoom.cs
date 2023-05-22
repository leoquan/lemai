using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class SchoolRoom
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String TenPhong { get; set; }
		public System.String FK_TrungTam { get; set; }
		public SchoolRoom(){}
	}
}
