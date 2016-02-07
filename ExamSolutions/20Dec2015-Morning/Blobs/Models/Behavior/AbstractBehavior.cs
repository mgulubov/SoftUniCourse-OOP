namespace Blobs.Models.Behavior
{
    using System;
    using Interfaces;
    using Utils;

    /// <summary>
    /// Abstract class for IBehavior objects.
    /// </summary>
    public abstract class AbstractBehavior : IBehavior
    {
        private int turnsCount = 0;

        /// <summary>
        /// Default constructor with no arguments. Initialises default values for the needed properties.
        /// </summary>
        protected AbstractBehavior()
        {
            this.IsActivated = false;
            this.WasAlreadyUsed = false;
            this.Owner = default(IBlob);
        }

        public bool IsActivated { get; private set; }

        public bool WasAlreadyUsed { get; private set; }

        protected IBlob Owner { get; private set; }

        public virtual void Update()
        {
            if (!this.IsActivated || this.turnsCount < 1)
            {
                if (this.IsActivated)
                {
                    this.turnsCount++;
                }

                throw new InvalidOperationException(ErrorMessages.BehaviorNotActive);
            }
        }

        public virtual void Activate()
        {
            if (this.IsActivated)
            {
                throw new InvalidOperationException(ErrorMessages.BehaviorIsAlreadyActive);
            }

            if (this.WasAlreadyUsed)
            {
                throw new InvalidOperationException(ErrorMessages.BehaviorWasAlreadyUsed);
            }

            this.IsActivated = true;
            this.WasAlreadyUsed = true;
        }

        public virtual void SetOwner(IBlob newOwner)
        {
            if (this.Owner != default(IBlob))
            {
                throw new InvalidOperationException(ErrorMessages.OwnerAlreadySet);
            }

            this.Owner = newOwner;
        }
    }
}
