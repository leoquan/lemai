using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class Room
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.String FK_TableGroup { get; set; }
		public System.String CreateBy { get; set; }
		public System.DateTime CreateDate { get; set; }
		public System.Int32 Status { get; set; }
		public System.String ImagePath { get; set; }
		public Room(){}
	}
}
