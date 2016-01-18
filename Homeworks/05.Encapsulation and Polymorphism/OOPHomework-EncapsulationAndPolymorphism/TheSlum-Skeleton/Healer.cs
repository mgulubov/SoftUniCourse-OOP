using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;


namespace TheSlum
{
    class Healer : Character, IHeal
    {
        public int HealingPoints { get; set; }

        public Healer(String id, int x, int y, Team team)
            : base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = 60;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            targetsList = targetsList.OrderBy(x => x.HealthPoints);
            return targetsList.First(x => x.Team == this.Team && x != this && x.IsAlive == true);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
