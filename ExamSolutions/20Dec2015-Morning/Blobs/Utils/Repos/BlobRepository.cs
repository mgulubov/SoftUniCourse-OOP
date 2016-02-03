namespace Blobs.Utils.Repos
{
    using System.Collections.Generic;
    using Interfaces;
    using Notifiers;

    public class BlobRepository : IRepository<IBlob>
    {
        private static readonly INotifier DefaultNotifier = new Notifier();
        private readonly INotifier notifier;
        private readonly IDictionary<string, IBlob> blobs;

        public BlobRepository()
            :this(DefaultNotifier)
        {
        }

        public BlobRepository(INotifier notifier)
        {
            this.notifier = notifier;
            this.blobs = new Dictionary<string, IBlob>();
        }

        public void Update()
        {
            this.UnregisterDeadBlobs();
            this.notifier.NotifyObservers();
        }

        public void Add(IBlob element)
        {
            if (!this.Contains(element))
            {
                this.blobs.Add(element.Name, element);
                this.notifier.RegisterObserver(element);
            }
        }

        public void Remove(IBlob element)
        {
            if (this.Contains(element))
            {
                this.blobs.Remove(element.Name);
                this.notifier.UnregisterObserver(element);
            }
        }

        public bool Contains(IBlob element)
        {
            return this.blobs.ContainsKey(element.Name);
        }

        public IBlob Get(string name)
        {
            return this.blobs[name];
        }

        public IEnumerable<IBlob> GetAll()
        {
            return this.blobs.Values;
        }

        private void UnregisterDeadBlobs()
        {
            foreach (IBlob blob in this.blobs.Values)
            {
                if (!blob.IsAlive())
                {
                    this.notifier.UnregisterObserver(blob);
                }
            }
        }
    }
}
