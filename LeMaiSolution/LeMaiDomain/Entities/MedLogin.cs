using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class MedLogin
	{
		//Khai bao các biến
		public System.String id { get; set; }
		public System.String id_user { get; set; }
		public System.String tenmay { get; set; }
		public System.DateTime ngaylogin { get; set; }
		public System.String ipaddress { get; set; }
		public MedLogin(){}
	}
}
