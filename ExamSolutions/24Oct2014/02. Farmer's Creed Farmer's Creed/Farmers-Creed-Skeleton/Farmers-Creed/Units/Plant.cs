namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit
    {
        private int growTime;
        private bool hasGrown;

        protected Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
            this.hasGrown = false;
        }

        public bool HasGrown
        {
            get { return this.hasGrown; }
        }

        public int GrowTime
        {
            get { return this.growTime; }
            set { throw new NotImplementedException(); }
        }

        public void Water()
        {
            throw new NotImplementedException();
        }

        public void Wither()
        {
            throw new NotImplementedException();
        }

        public void Grow()
        {
            throw new NotImplementedException();
        }
    }
}
