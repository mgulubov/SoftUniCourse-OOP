using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ProblemGenericList.Interfaces
{
    public interface IGenericList<T>
    {
        T Get(int index);
        T Delete(int index);
        T Set(int index, T value);
        int Size();
        int IndexOf(T value);
        bool Contains(T value);
        bool IsEmpty();
        bool Delete(T value);
        void Clear();
        void Add(T value);
        void Insert(int index, T value);
    }
}
