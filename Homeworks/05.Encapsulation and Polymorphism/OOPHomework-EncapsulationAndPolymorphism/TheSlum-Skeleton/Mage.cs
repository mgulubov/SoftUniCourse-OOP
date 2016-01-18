using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Mage : Character, IAttack
    {
        public int AttackPoints { set; get; }

        public Mage(String id, int x, int y, Team team)
            : base(id, x, y, 150, 50, team, 5)
        {
            this.AttackPoints = 300;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Last(x => x.Team != this.Team && x.IsAlive == true);
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
