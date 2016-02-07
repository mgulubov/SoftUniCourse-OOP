namespace Blobs.Models
{
    using System;
    using Interfaces;
    using Utils;

    /// <summary>
    /// Concreate implementation of IBlob. Extends Character.
    /// </summary>
    public class Blob : Character, IBlob
    {
        private readonly IAttack attack;
        private readonly IBehavior behavior;
        private readonly int initialHealth;
        private readonly int initialDamage;
        private int health;
        private int damage;

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob"/> class.
        /// </summary>
        /// <param name="name">The name of the blob.</param>
        /// <param name="health">The initial health value of the blob.</param>
        /// <param name="damage">The initial damage value of the blob.</param>
        /// <param name="attack">The Attack object of the blob.</param>
        /// <param name="behavior">The behavior object of the blob.</param>
        public Blob(string name, int health, int damage, IAttack attack, IBehavior behavior) 
            : base(name)
        {
            this.initialHealth = health;
            this.initialDamage = damage;
            this.Health = this.initialHealth;
            this.Damage = this.initialDamage;
            this.attack = attack;
            this.behavior = behavior;
            this.attack.SetOwner(this);
            this.behavior.SetOwner(this);
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            private set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.health = value;
                if (this.ShouldActivateBehavior())
                {
                    this.behavior.Activate();
                }
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(value.ToString(), ErrorMessages.InvalidBlobDamageValue);
                }

                this.damage = value;
            }
        }

        public void Attack(IAttackable otherCharacter)
        {
            if (!this.IsAlive())
            {
                throw new InvalidOperationException(ErrorMessages.DeadBlobAttackError);
            }

            this.attack.Attack(otherCharacter);
        }

        public void Update()
        {
            if (this.IsAlive() && !this.BehaviorIsNotActive())
            {
                this.behavior.Update();
            }
        }

        public void AdjustDamageBy(int adjustValue)
        {
            this.Damage += adjustValue;
        }

        public void TakeDamage(int damageTaken)
        {
            if (damageTaken < 0)
            {
                throw new ArgumentOutOfRangeException(damageTaken.ToString(), ErrorMessages.TakenDamageMustBePositive);
            }

            this.Health -= damageTaken;
        }

        public void AddHealth(int healthBonus)
        {
            if (healthBonus < 0)
            {
                throw new ArgumentOutOfRangeException(healthBonus.ToString(), ErrorMessages.HealthBonusMustBePositive);
            }

            this.Health += healthBonus;
        }

        public bool IsAlive()
        {
            return this.Health > 0;
        }

        public int GetInitialDamage()
        {
            return this.initialDamage;
        }

        public int GetInitialHealth()
        {
            return this.initialHealth;
        }

        public override string ToString()
        {
            string result = this.IsAlive()
                ? string.Format("Blob {0}: {1} HP, {2} Damage", this.Name, this.Health, this.Damage)
                : string.Format("Blob {0} KILLED", this.Name);
            
            return result;
        }

        private bool ShouldActivateBehavior()
        {
            return 
                this.HealthConditionIsMet(this.Health) && 
                this.BehaviorIsNotActive() &&
                this.BehaviorWasNotActivated();
        }

        private bool HealthConditionIsMet(int healthValue)
        {
            return healthValue <= (this.initialHealth / 2);
        }

        private bool BehaviorIsNotActive()
        {
            return !this.behavior.IsActivated;
        }

        private bool BehaviorWasNotActivated()
        {
            return !this.behavior.WasAlreadyUsed;
        }
    }
}
