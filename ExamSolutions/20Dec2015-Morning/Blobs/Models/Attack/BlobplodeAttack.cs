namespace Blobs.Models.Attack
{
    using Interfaces;

    public class BlobplodeAttack : AbstractAttack
    {
        public override void SetOwner(IBlob newOwner)
        {
            base.SetOwner(newOwner);
            this.Damage = this.owner.Damage*2;
        }

        public override void Attack(IAttackable otherCharacter)
        {
            base.Attack(otherCharacter);
            int selfDamage = this.owner.Health / 2;
            if (this.owner.Health - selfDamage <= 0)
            {
                selfDamage++;
            }
            this.owner.TakeDamage(selfDamage);
        }
    }
}
