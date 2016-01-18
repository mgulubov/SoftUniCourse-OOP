using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using _03.ProblemGenericList.Interfaces;

namespace _03.ProblemGenericList.Classes
{
    public class GenericList<T> : IGenericList<T>
    {
        private Version _version;
        private Assembly _thisAssembl;
        private AssemblyName _thisAssemblName;
        private static readonly int DEFAUL_CAPACITY = 16;
        private int _initialCapacity;
        private T[] _array;
        private int _size;
        

        public GenericList()
            : this(DEFAUL_CAPACITY)
        {

        }

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("capacity can't be <= 0");
            }

            this._initialCapacity = capacity;
            this.Clear(this._initialCapacity);
            this._thisAssembl = typeof(GenericList<T>).Assembly;
            this._thisAssemblName = this._thisAssembl.GetName();
            this._version = _thisAssemblName.Version;
        }

        public void Insert(int index, T value)
        {
            this.CheckIfValueIsValid(value, "Can't insert value. Invalid value");
            if (index < 0 || index > this.Size())
            {
                throw new IndexOutOfRangeException("Can't insert value. Invalid index");
            }

            this.EnsureCapacity();

            Array.Copy(this._array, index, this._array, index + 1, this.Size() - index);
            this._array[index] = value;

            this._size++;
        }

        public void Add(T value)
        {
            this.Insert(this.Size(), value);
        }

        public T Delete(int index)
        {
            this.CheckIfIndexIsValid(index, "Can't delete value. Invalid Index");

            T deletedValue = this.Get(index);
            this._array[index] = default(T);
            Array.Copy(this._array, index + 1, this._array, index, this.Size() - (index + 1));
            this._size--;

            return deletedValue;
        }

        public bool Delete(T value)
        {
            this.CheckIfValueIsValid(value, "Can't delete value. Invalid value");

            if (!this.Contains(value))
            {
                return false;
            }

            int index = this.IndexOf(value);
            this.Delete(index);
            return true;
        }

        public T Get(int index)
        {
            this.CheckIfIndexIsValid(index, "Can't get element. Invalid Index");

            return this._array[index];
        }

        public T Set(int index, T value)
        {
            this.CheckIfIndexIsValid(index, "Can't set value. Invalid index");
            this.CheckIfValueIsValid(value, "Can't set value. Invalid value");

            T replacedValue = this.Get(index);
            this._array[index] = value;

            return replacedValue;
        }

        public int IndexOf(T value)
        {
            int index = -1;
            for (int i = 0; i < this.Size(); i++)
            {
                if (this._array[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int Size()
        {
            return this._size;
        }

        public void Clear()
        {
            this.Clear(DEFAUL_CAPACITY);
        }

        public bool Contains(T value)
        {
            if (this.IndexOf(value) == -1)
            {
                return false;
            }
            return true;
        }

        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        public override string ToString()
        {
            return String.Format("[{0}]", String.Join(", ", this._array));
        }

        public T Min()
        {
            return this._array.Min();
        }

        public T Max()
        {
            return this._array.Max();
        }

        public String GetVersion()
        {
            return String.Format("This is version {0} of {1}", this._version, this._thisAssemblName.Name);
        }

        private void Clear(int capacity)
        {
            this._initialCapacity = capacity;
            this._array = new T[this._initialCapacity];
            this._size = 0;
        }

        private void CheckIfIndexIsValid(int index, String message)
        {
            if (index < 0 || index >= this.Size())
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        private void EnsureCapacity()
        {
            if (this.Size() >= this._array.Length)
            {
                this.ResizeArray();
            }
        }

        private void ResizeArray()
        {
            int newCapacity = this.Size() * 2;

            T[] tmpArray = new T[newCapacity];
            Array.Copy(this._array, 0, tmpArray, 0, this.Size());

            this._array = tmpArray;
        }

        private void CheckIfValueIsValid(T value, String message)
        {
            if (value == null)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
