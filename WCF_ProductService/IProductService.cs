using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WCF_ProductService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IProductService
	{
		[OperationContract]
		[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Product/{id}")]
		Product GetProduct(string id);

		[OperationContract]
		[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Products")]
		List<Product> GetProducts();
	}
}
