namespace Blobs.Models.Attack
{
    using System;
    using Interfaces;
    using Utils;

    /// <summary>
    /// Abstract attack class.
    /// </summary>
    public abstract class AbstractAttack : IAttack
    {
        private int damage;

        /// <summary>
        /// Default constructor.
        /// </summary>
        protected AbstractAttack()
        {
            this.Owner = default(IBlob);
            this.damage = 0;
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(), ErrorMessages.InvalidAttackDamage);
                }

                this.damage = value;
            }
        }

        protected IBlob Owner { get; private set; }

        public virtual void Attack(IAttackable otherCharacter)
        {
            if (this.Owner == default(IBlob))
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
            if (this.Owner != default(IBlob))
            {
                throw new InvalidOperationException(ErrorMessages.OwnerAlreadySet);
            }

            this.Owner = newOwner;
        }

        public void AdjustDamageBy(int adjustValue)
        {
            this.Damage += adjustValue;
        }
    }
}
