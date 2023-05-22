using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpAccept
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String AcceptMan { get; set; }
		public System.String AcceptPhone { get; set; }
		public System.String AcceptAddress { get; set; }
		public System.String AcceptAddressFull { get; set; }
		public System.Int32 AcceptProvince { get; set; }
		public System.Int32 AcceptDistrict { get; set; }
		public System.String AcceptWard { get; set; }
		public System.Int32 AcceptLevel { get; set; }
		public GExpAccept(){}
	}
}
