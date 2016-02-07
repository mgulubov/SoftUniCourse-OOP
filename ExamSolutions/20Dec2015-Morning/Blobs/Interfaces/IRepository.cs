namespace Blobs.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for repository objects.
    /// </summary>
    /// <typeparam name="T">The type of objects that the repository will store.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Method for adding new elements.
        /// </summary>
        /// <param name="element">The element to be added.</param>
        void Add(T element);

        /// <summary>
        /// Method for removing elements.
        /// </summary>
        /// <param name="element">The element to be removed.</param>
        void Remove(T element);

        /// <summary>
        /// Method for checking if an element is currently in the repository.
        /// </summary>
        /// <param name="element">The element to be checked.</param>
        /// <returns>True if the element exists. False if not.</returns>
        bool Contains(T element);

        /// <summary>
        /// Get element by name.
        /// </summary>
        /// <param name="name">The name of the element.</param>
        /// <returns>The element if found.</returns>
        T Get(string name);

        /// <summary>
        /// Method for getting all elements in the repository.
        /// </summary>
        /// <returns>An enumeration of all elements currently added in the repository.</returns>
        IEnumerable<T> GetAll();
    }
}
