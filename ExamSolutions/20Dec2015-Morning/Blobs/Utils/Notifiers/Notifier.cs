namespace Blobs.Utils.Notifiers
{
    using System.Collections.Generic;
    using Interfaces;

    /// <summary>
    /// Concrete implementation of INotifier.
    /// </summary>
    public class Notifier : INotifier
    {
        private readonly ICollection<IUpdateable> observers;

        /// <summary>
        /// Default constructor with 0 arguments. 
        /// Initialises the observers field with a List object of IUpdateable generic type.
        /// </summary>
        public Notifier()
        {
            this.observers = new List<IUpdateable>();
        }

        public void RegisterObserver(IUpdateable observer)
        {
            if (!this.ObserverIsRegistered(observer))
            {
                this.observers.Add(observer);
            }
        }

        public void UnregisterObserver(IUpdateable observer)
        {
            if (this.ObserverIsRegistered(observer))
            {
                this.observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (IUpdateable observer in this.observers)
            {
                observer.Update();   
            }
        }

        public bool ObserverIsRegistered(IUpdateable observer)
        {
            return this.observers.Contains(observer);
        }
    }
}
