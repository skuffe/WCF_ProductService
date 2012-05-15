using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCF_ProductService;

namespace WCF_ProductService_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceClient client = new ProductServiceClient("WSHttpBinding_IProductService", "http://192.168.139.93:8732/ProductService/ws");
            Product p = client.GetProduct("1");
            Console.WriteLine("Productname: " + p.ProductName);
            Console.ReadLine();
        }
    }
}
