using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class GsCountry
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String CountryCode { get; set; }
		public System.String CommonName { get; set; }
		public System.String FormalName { get; set; }
		public System.String CountryType { get; set; }
		public System.String CountrySubType { get; set; }
		public System.String Sovereignty { get; set; }
		public System.String Capital { get; set; }
		public System.String CurrencyCode { get; set; }
		public System.String CurrencyName { get; set; }
		public System.String TelephoneCode { get; set; }
		public System.String CountryCode3 { get; set; }
		public System.String CountryNumber { get; set; }
		public System.String InternetCountryCode { get; set; }
		public System.Int32 SortOrder { get; set; }
		public System.Boolean IsPublished { get; set; }
		public System.String Flags { get; set; }
		public System.Boolean IsDeleted { get; set; }
		public GsCountry(){}
	}
}
