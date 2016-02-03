namespace Blobs.Models.Attack
{
    using System;
    using Interfaces;
    using Utils;

    public abstract class AbstractAttack : IAttack
    {
        private int damage;
        protected IBlob owner;

        protected AbstractAttack()
        {
            this.owner = default(IBlob);
            this.damage = 0;
        }

        public int Damage
        {
            get { return this.damage; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(), ErrorMessages.InvalidAttackDamage);
                }
                this.damage = value;
            }
        }

        public virtual void Attack(IAttackable otherCharacter)
        {
            if (this.owner == default(IBlob))
            {
                throw new InvalidOperationException(ErrorMessages.OwnerNotSet);
            }

            if (!otherCharacter.IsAlive())
            {
                throw new InvalidOperationException(ErrorMessages.DeadBlobAttackedError);
            }

            otherCharacter.TakeDamage(this.Damage);
        }

        public virtual void SetOwner(IBlob newOwner)
        {
            if (this.owner != default(IBlob))
            {
                throw new InvalidOperationException(ErrorMessages.OwnerAlreadySet);
            }
            this.owner = newOwner;
        }

        public void AdjustDamageBy(int adjustValue)
        {
            this.Damage += adjustValue;
        }
    }
}
