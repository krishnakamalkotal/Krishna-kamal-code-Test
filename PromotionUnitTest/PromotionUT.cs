using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine_Krishnakamal;

namespace PromotionUnitTest
{
    [TestClass]
    public class PromotionUT
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> inputs = new List<string>(){ "A", "B", "C", "D" };
            List<Product> products = new List<Product>();
            foreach (var input in inputs)
            {
                Product p = new Product(input);
                products.Add(p);
            }
            ProductPrice pp = new ProductPrice();
            var getdata = pp.GetProductTotalPrice(products);
            Assert.IsNotNull(getdata);
        }
    }
}
