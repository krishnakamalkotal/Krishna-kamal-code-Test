using System;
using System.Collections.Generic;

namespace PromotionEngine_Krishnakamal
{
   public class PromotionEngine
    {
       public static void Main(string[] args)
        {
            
            Console.WriteLine("Total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            CreateProduct cp = new CreateProduct();
            List<Product> prod = cp.GetProductList(a);
            ProductPrice pp = new ProductPrice();
            int totalPrice = pp.GetProductTotalPrice(prod);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
        
    }
}

 