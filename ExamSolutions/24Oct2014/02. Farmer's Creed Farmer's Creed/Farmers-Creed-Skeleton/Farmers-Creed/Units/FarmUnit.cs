using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable
    {
        private readonly string productId;
        private readonly ProductType productType;
        private int health;
        private int productionQunatity;
        private bool isAlive;

        protected FarmUnit(string id, int health, int productionQuantity, ProductType productType)
            : base(id)
        {
            this.productId = id + "Product";
            this.Health = health;
            this.ProductionQuantity = productionQuantity;
            this.productType = productType;
            this.isAlive = true;
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    this.isAlive = false;
                }

                this.health = value;
            }
        }

        public bool IsAlive
        {
            get { return this.isAlive; }
        }

        public int ProductionQuantity
        {
            get { return this.productionQunatity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(productionQunatity.ToString(), 
                        "Product quantity can't be < 0");
                }
                this.productionQunatity = value;
            }
        }

        public virtual Product GetProduct()
        {
            Product product = new Product(this.productId, this.productType, this.ProductionQuantity);
            return product;
        }
    }
}
