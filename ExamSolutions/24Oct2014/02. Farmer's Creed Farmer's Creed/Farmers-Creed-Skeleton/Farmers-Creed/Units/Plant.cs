namespace FarmersCreed.Units
{
    public abstract class Plant : FarmUnit
    {
        private int growTimeCounter;
        private bool hasGrown;

        protected Plant(string id, int health, int productionQuantity, int growTime, ProductType productType)
            : base(id, health, productionQuantity, productType)
        {
            this.hasGrown = false;
        }

        public bool HasGrown
        {
            get { return this.hasGrown; }
        }

        public int GrowTime
        {
            get { return this.growTimeCounter; }
            set
            {
                if (!HasGrown)
                {
                    this.growTimeCounter = value;
                    if (this.growTimeCounter <= 0)
                    {
                        this.hasGrown = true;
                    }
                }
            }
        }

        public void Water()
        {
            this.Health += 2;
        }

        public void Wither()
        {
            this.Health -= 1;
        }

        public virtual void Grow()
        {
            this.GrowTime -= 1;
        }
    }
}
