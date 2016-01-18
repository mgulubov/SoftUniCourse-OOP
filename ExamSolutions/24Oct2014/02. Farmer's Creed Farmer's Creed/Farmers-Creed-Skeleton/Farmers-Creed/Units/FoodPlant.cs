using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    public abstract class FoodPlant : Plant, IEdible
    {
        private readonly ProductType productType;

        protected FoodPlant(string id, int health, int productionQuantity, int growTime, ProductType productType) : 
            base(id, health, productionQuantity, growTime, productType)
        {
        }

        public ProductType ProductType { get; set; }
        public int Quantity { get; set; }
        public FoodType FoodType { get; set; }
        public int HealthEffect { get; set; }
    }
}
