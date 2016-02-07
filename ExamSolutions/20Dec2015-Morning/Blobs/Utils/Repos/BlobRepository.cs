namespace Blobs.Utils.Repos
{
    using System.Collections.Generic;
    using Interfaces;
    using Notifiers;

    /// <summary>
    /// Concrate implementation of IRepository of IBlob. Implements IUpdateable.
    /// </summary>
    public class BlobRepository : IRepository<IBlob>, IUpdateable
    {
        private readonly INotifier notifier;
        private readonly IDictionary<string, IBlob> blobs;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobRepository"/> class.
        /// </summary>
        public BlobRepository()
            : this(new Notifier())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobRepository"/> class.
        /// </summary>
        /// <param name="notifier">INotifier object used in the Update method.</param>
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
