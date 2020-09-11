using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine_Krishnakamal
{
   public class ProductPrice: IProductPrice
    {
        public int GetProductTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product prod in products)
            {
                switch (prod.ProductId)
                {
                    case "A":
                    case "a":
                        counterofA += 1;
                        break;
                    case "B":
                    case "b":
                        counterofB += 1;
                        break;
                    case "C":
                    case "c":
                        CounterofC += 1;
                        break;
                    case "D":
                    case "d":
                        CounterofD += 1;
                        break;
                }
            }

            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
