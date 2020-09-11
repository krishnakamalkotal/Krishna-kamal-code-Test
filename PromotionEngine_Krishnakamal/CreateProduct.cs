using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine_Krishnakamal
{
   public class CreateProduct:ICreateProduct
    {
        public List<Product> GetProductList(int a)
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }
            return products;
        } 
    }
}
