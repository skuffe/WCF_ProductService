using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCF_ProductService
{
	// Use a data contract as illustrated in the sample below to add composite types to service operations
	[DataContract]
	public class Product
	{
		[DataMember]
		public int ProductID { get; set; }
		[DataMember]
		public string ProductName { get; set; }
		[DataMember]
		public string QuantityPerUnit { get; set; }
		[DataMember]
		public decimal UnitPrice { get; set; }
		[DataMember]
		public bool? Discontinued { get; set; }
	}
}
