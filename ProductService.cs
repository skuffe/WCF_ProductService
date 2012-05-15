using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WCFandEFService
{
	public class ProductService : IProductService
	{
		public Product GetProduct(string id)
		{
			WCFTestEntities context = new WCFTestEntities();
			int idAsInt = int.Parse(id);
			
			var productEntity = (from p
								 in context.ProductEntities
								 where p.ProductID == idAsInt
								 select p).FirstOrDefault();
			if (productEntity != null)
				return ConvertProductEntityToProduct(productEntity);
			else
				throw new Exception("Invalid product id");
		}

		private Product ConvertProductEntityToProduct(
						ProductEntity productEntity)
		{
			Product product = new Product();
			product.ProductID = productEntity.ProductID;
			product.ProductName = productEntity.ProductName;
			product.QuantityPerUnit = productEntity.QuantityPerUnit;
			product.UnitPrice = (decimal)productEntity.UnitPrice;
			product.Discontinued = productEntity.Discontinued;
			return product;
		}

		public List<Product> GetProducts()
		{
			WCFTestEntities context = new WCFTestEntities();

			var products = (from p
							in context.ProductEntities
							select p).ToList();
			List<Product> productList = new List<Product>();

			foreach (ProductEntity product in products) {
				productList.Add(this.ConvertProductEntityToProduct(product));
			}

			return productList;
		}
	}
}
