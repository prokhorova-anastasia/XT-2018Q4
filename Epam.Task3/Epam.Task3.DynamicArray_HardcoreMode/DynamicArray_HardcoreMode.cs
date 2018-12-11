using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace Epam.Task3.DynamicArray_HardcoreMode
{
    public class DynamicArray_HardcoreMode<T> : IEnumerable, IEnumerable<T>, ICloneable
    {
        private T[] storage;
        private int length = 0;

        public DynamicArray_HardcoreMode()
        {
            this.storage = new T[8];
        }

        public DynamicArray_HardcoreMode(int length)
        {
            this.storage = new T[length];
        }

        public DynamicArray_HardcoreMode(IEnumerable<T> mas)
        {
            this.storage = new T[mas.Count()];
            foreach (var item in mas)
            {
                this.storage[this.length] = item;
                this.length++;
            }

            this.length++;
        }

        public int Length
        {
            get
            {
                return this.length - 1;
            }
        }

        public int Capacity
        {
            get
            {
                return this.storage.Count();
            }
        }

        public T this[int id]
        {
            get
            {
                if (id > this.length || -id + 1 > this.length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (id > -1)
                {
                    return this.storage[id];
                }
                else
                {
                    return this.storage[this.length - 1 + id];
                }
            }

            set
            {
                if (id > this.length || -id + 1 > this.length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (id > -1)
                {
                    this.storage[id] = value;
                }
                else
                {
                    this.storage[this.length - 1 + id] = value;
                }
            }
        }

        public void Add(T val)
        {
            if (this.length == this.storage.Count())
            {
                this.ExpandMas(this.length * 2);
            }

            this.storage[this.length] = val;
            this.length++;
        }

        public void ChangeCapacity(int val)
        {
            this.ExpandMas(val);
        }

        public void AddRange(IEnumerable<T> mas)
        {
            if (mas.Count() > this.storage.Count() - this.length + 1)
            {
                this.ExpandMas(this.length + mas.Count() + 1);
            }

            foreach (var item in mas)
            {
                this.storage[this.length] = item;
                this.length++;
            }

            this.length++;
        }

        public bool Remove(int pos)
        {
            if (pos >= this.length || pos < 0)
            {
                return false;
            }

            for (int i = pos; i + 1 < this.length - 1; i++)
            {
                this.storage[i] = this.storage[i + 1];
            }

            this.length--;
            return true;
        }

        public object Clone()
        {
            return new DynamicArray_HardcoreMode<T>
            {
                storage = this.storage,
                length = this.length,
            };
        }

        public bool Insert(int pos, T value)
        {
            if (pos >= this.length)
            {
                throw new Exception("ArgumentOutOfRangeException");
            }
            else if (pos < 0)
            {
                return false;
            }

            if (this.length + 1 >= this.storage.Count())
            {
                this.ExpandMas(this.length * 2);
            }

            for (int i = this.length; i > pos; i--)
            {
                this.storage[i] = this.storage[i - 1];
            }

            this.length++;
            this.storage[pos] = value;
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)this.GetEnumerator();
        }

        public T[] ToArray()
        {
            return this.storage;
        }

        private void ExpandMas(int val)
        {
            T[] t = this.storage;
            this.storage = new T[val];
            for (int i = 0; i < t.Count() && i < this.storage.Count(); i++)
            {
                this.storage[i] = t[i];
            }
        }
    }
}
