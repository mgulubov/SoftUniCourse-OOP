namespace Blobs.Interfaces
{
    using System.Collections.Generic;

    public interface IRepository<T> : IUpdateable
    {
        void Add(T element);

        void Remove(T element);

        bool Contains(T element);

        T Get(string name);

        IEnumerable<T> GetAll();
    }
}
