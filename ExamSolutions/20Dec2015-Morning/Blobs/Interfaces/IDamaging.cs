namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for objects that can fo damage
    /// </summary>
    public interface IDamaging
    {
        /// <summary>
        /// A Damage property. Setter can be private.
        /// </summary>
        int Damage { get; }

        /// <summary>
        /// Method for adjusting the Damage proprty.
        /// </summary>
        /// <param name="adjustValue">The value which will be added/deducted from the Damage property.</param>
        void AdjustDamageBy(int adjustValue);

        /// <summary>
        /// Method for attacking IAttackable objects.
        /// </summary>
        /// <param name="otherCharacter"></param>
        void Attack(IAttackable otherCharacter);
    }
}
