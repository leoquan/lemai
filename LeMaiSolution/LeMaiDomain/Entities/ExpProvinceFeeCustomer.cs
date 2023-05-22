using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeMaiDomain
{
	[Serializable()]
	public class ExpProvinceFeeCustomer
	{
		//Khai bao các biến
		public System.String Id { get; set; }
		public System.String Name { get; set; }
		public System.Int32 Less1MN { get; set; }
		public System.Int32 Less1MT { get; set; }
		public System.Int32 Less1MB { get; set; }
		public System.Int32 Less2MN { get; set; }
		public System.Int32 Less2MT { get; set; }
		public System.Int32 Less2MB { get; set; }
		public System.Int32 Less3MN { get; set; }
		public System.Int32 Less3MT { get; set; }
		public System.Int32 Less3MB { get; set; }
		public System.Int32 Less4MN { get; set; }
		public System.Int32 Less4MT { get; set; }
		public System.Int32 Less4MB { get; set; }
		public System.Int32 Less5MN { get; set; }
		public System.Int32 Less5MT { get; set; }
		public System.Int32 Less5MB { get; set; }
		public System.Int32 InitAll { get; set; }
		public System.Int32 InitMN { get; set; }
		public System.Int32 InitMT { get; set; }
		public System.Int32 InitMB { get; set; }
		public System.Int32 InitWeight { get; set; }
		public System.Int32 NextWeightAll { get; set; }
		public System.Int32 NextWeightMN { get; set; }
		public System.Int32 NextWeightMT { get; set; }
		public System.Int32 NextWeightMB { get; set; }
		public System.Boolean UsingLess { get; set; }
		public System.Boolean UsingZone { get; set; }
		public ExpProvinceFeeCustomer(){}
	}
}
