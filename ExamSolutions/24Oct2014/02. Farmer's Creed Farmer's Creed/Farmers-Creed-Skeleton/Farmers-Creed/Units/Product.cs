namespace FarmersCreed.Units
{
    using System;

    public class Product : GameObject, IProduct
    {
        private int quantity;

        public Product(string id, ProductType productType, int quantity)
            : base(id)
        {
            this.Quantity = quantity;
            this.ProductType = productType;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(), "Product quantity cannot be negative!");
                }
                this.quantity = value;
            }
        }

        public ProductType ProductType { get; set; }
    }
}
