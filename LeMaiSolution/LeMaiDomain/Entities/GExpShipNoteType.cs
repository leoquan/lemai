using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GExpShipNoteType
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String ShipNoteType { get; set; }
		public System.String ShipNoteCode { get; set; }
		public System.String ShipNoteCodeGHN { get; set; }
		public GExpShipNoteType(){}
	}
}
