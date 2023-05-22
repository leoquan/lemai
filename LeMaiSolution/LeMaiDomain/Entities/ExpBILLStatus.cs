using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpBILLStatus
	{
		//Khai bao các biến
		public System.Int32 Id { get; set; }
		public System.String StatusName { get; set; }
		public System.String GhiChu { get; set; }
		public System.Boolean? SelectNV { get; set; }
		public System.Int32? SortIndex { get; set; }
		public ExpBILLStatus(){}
	}
}
