namespace Blobs.Models.Attack
{
    using Interfaces;

    /// <summary>
    /// Concrete implementation of AbstractAttack.
    /// </summary>
    public class BlobplodeAttack : AbstractAttack
    {
        public override void SetOwner(IBlob newOwner)
        {
            base.SetOwner(newOwner);
            this.SetDamage();
        }

        public override void Attack(IAttackable otherCharacter)
        {
            int selfDamage = this.Owner.Health / 2;
            if (this.Owner.Health - selfDamage <= 0)
            {
                selfDamage++;
            }

            this.Owner.TakeDamage(selfDamage);
            this.SetDamage();

            base.Attack(otherCharacter);
        }

        private void SetDamage()
        {
            this.Damage = this.Owner.Damage * 2;
        }
    }
}
