using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine_Krishnakamal
{
   public interface IProductPrice
    {
        public int GetProductTotalPrice(List<Product> products);
    }
}
