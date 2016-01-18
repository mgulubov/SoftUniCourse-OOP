using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public class TobaccoPlant : Plant
    {
        private const int HealthBase = 12;
        private const int GrowTimeBase = 4;
        private const int ProductionQunatityBase = 10;
        private const ProductType ProductTypeBase = ProductType.Tobacco;

        public TobaccoPlant(string id) :
            base(id, HealthBase, ProductionQunatityBase, GrowTimeBase, ProductTypeBase)
        {
        }

        public override void Grow()
        {
            this.GrowTime -= 2;
        }

        public override Product GetProduct()
        {
            if (!this.HasGrown)
            {
                throw new InvalidOperationException(string.Format("{0} cannot produce while growing.", this.Id));
            }
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(string.Format("{0} cannot produce if dead.", this.Id));
            }

            return base.GetProduct();
        }
    }
}
