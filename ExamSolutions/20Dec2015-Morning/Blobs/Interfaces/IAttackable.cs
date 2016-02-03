namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for objects that can be attacked
    /// </summary>
    public interface IAttackable
    {
        /// <summary>
        /// Health property.
        /// </summary>
        int Health { get; }

        /// <summary>
        /// Method for checking if the object is alive.
        /// </summary>
        /// <returns>Returns True if the object is alive and False if the object is considered dead.</returns>
        bool IsAlive();

        /// <summary>
        /// Method for taking damage from an opponent.
        /// </summary>
        /// <param name="damageTaken">The amount of damage to be taken.</param>
        void TakeDamage(int damageTaken);

        /// <summary>
        /// Method for adding health bonus.
        /// </summary>
        /// <param name="healthBonus">The amount of health to be added to the Health property.</param>
        void AddHealth(int healthBonus);
    }
}
