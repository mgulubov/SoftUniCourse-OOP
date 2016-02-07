namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for objects that have IBlobl owners.
    /// </summary>
    public interface IOwned
    {
        /// <summary>
        /// Method for setting Owners.
        /// </summary>
        /// <param name="blob">The new owner object.</param>
        void SetOwner(IBlob blob);
    }
}
