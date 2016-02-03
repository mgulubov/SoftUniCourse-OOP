namespace Blobs.Interfaces
{
    /// <summary>
    /// Interface for Notifier objects - Observer [GOF].
    /// </summary>
    public interface INotifier
    {
        /// <summary>
        /// Method for registering IObserver objects to the Subject's notification list.
        /// </summary>
        /// <param name="observer">The observer to be registered.</param>
        void RegisterObserver(IUpdateable observer);

        /// <summary>
        /// Method for removing an IUpdateable object from the Subject's notification list.
        /// </summary>
        /// <param name="observer">The observer object to be unregistered.</param>
        void UnregisterObserver(IUpdateable observer);

        /// <summary>
        /// Method for sending an Update notification to all currently registered observers.
        /// </summary>
        void NotifyObservers();

        /// <summary>
        /// Method for checking if an observer is currently registered.
        /// </summary>
        /// <param name="observer">The observer to be checked.</param>
        /// <returns>True if the observer is registered. False if it's not.</returns>
        bool ObserverIsRegistered(IUpdateable observer);
    }
}
