using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable
    {
        private int health;
        private int productionQunatity;
        private bool isAlive;

        protected FarmUnit(string id, int health, int productionQuantity)
            : base(id)
        {
            this.Health = health;
            this.ProductionQuantity = productionQuantity;
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

        public abstract Product GetProduct();
    }
}
