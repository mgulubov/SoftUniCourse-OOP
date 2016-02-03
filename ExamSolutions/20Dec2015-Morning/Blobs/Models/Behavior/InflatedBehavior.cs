namespace Blobs.Models.Behavior
{
    using System;

    public class InflatedBehavior : AbstractBehavior
    {
        public override void Activate()
        {
            base.Activate();
            int healthBonus = 50;
            this.Owner.AddHealth(healthBonus);
        }

        public override void Update()
        {
            try
            {
                base.Update();
            }
            catch (InvalidOperationException)
            {
                return;
            }

            int damageDone = 10;
            this.Owner.TakeDamage(damageDone);
        }
    }
}
