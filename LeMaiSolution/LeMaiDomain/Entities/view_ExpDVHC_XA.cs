using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class view_ExpDVHC_XA
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Ten { get; set; }
		public System.String Cap { get; set; }
		public System.String CapTren { get; set; }
		public System.Boolean? InternalPost { get; set; }
		public System.String TenHuyen { get; set; }
		public System.String TenTinh { get; set; }
		public view_ExpDVHC_XA(){}
	}
}
