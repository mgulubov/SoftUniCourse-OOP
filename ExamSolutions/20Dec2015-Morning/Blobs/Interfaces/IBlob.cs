namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Blob objects.
    /// </summary>
    public interface IBlob : ICharacter, IAttackable, IDamaging, IUpdateable
    {
        /// <summary>
        /// Method for returning the initial Damage value.
        /// </summary>
        /// <returns>The initial damage value.</returns>
        int GetInitialDamage();

        /// <summary>
        /// Method for returning the initial Health value.
        /// </summary>
        /// <returns>The initial health value.</returns>
        int GetInitialHealth();
    }
}
