namespace Blobs.Utils.Notifiers
{
    using System.Collections.Generic;
    using Interfaces;

    public class Notifier : INotifier
    {
        private readonly ICollection<IUpdateable> observers;

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
            foreach (IUpdateable observer in observers)
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
