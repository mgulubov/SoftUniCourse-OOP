namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Factory objects.
    /// </summary>
    /// <typeparam name="T">The type of object which the factory will return.</typeparam>
    public interface IFactory<out T>
    {
        /// <summary>
        /// Create method.
        /// </summary>
        /// <param name="parameters">String array, containing information required for the creation of the T object.</param>
        /// <returns>New Object of type T</returns>
        T Create(string[] parameters);
    }
}
