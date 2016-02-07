namespace Blobs.Models.Behavior
{
    using System;

    /// <summary>
    /// Concrete implementation of AbstractBehavior.
    /// </summary>
    public class AggressiveBehavior : AbstractBehavior
    {
        public override void Activate()
        {
            base.Activate();
            int damageBonus = this.Owner.Damage;
            this.Owner.AdjustDamageBy(damageBonus);
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
            
            int deductedDamage = 5;
            this.UpdateOwnerDamage(deductedDamage);
        }

        private void UpdateOwnerDamage(int deductedDamage)
        {
            if (this.DamageCanBeUpdated(deductedDamage))
            {
                this.Owner.AdjustDamageBy(-deductedDamage);
            }
        }

        private bool DamageCanBeUpdated(int deductedDamage)
        {
            return this.Owner.Damage - deductedDamage >= this.Owner.GetInitialDamage();
        }
    }
}
