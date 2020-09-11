namespace PromotionEngine_Krishnakamal
{
	public class Product
	{
		public string ProductId { get; set; }
		public decimal ProductPrice { get; set; }

        public Product(string productid)
        {
            this.ProductId = productid;
            switch (productid)
            {
                case "A":
                    this.ProductPrice = 50m;

                    break;
                case "B":
                    this.ProductPrice = 30m;

                    break;
                case "C":
                    this.ProductPrice = 20m;

                    break;
                case "D":
                    this.ProductPrice = 2015m;
                    break;
            }
        }
    }
}
