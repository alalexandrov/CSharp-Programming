using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GenericListImplementation
{
    public static class Extensions
    {
        public static T Max<T>(this GenericList<T> list) where T : IComparable<T>
        {
            T Max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(Max) == 1)
                {
                    Max = list[i];
                }
            }

            return Max;
        }

        public static T Min<T>(this GenericList<T> list) where T : IComparable<T>
        {
            T Min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(Min) == -1)
                {
                    Min = list[i];
                }
            }

            return Min;
        }
    }
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] elements;
        private int count = 0;

        public int Count
        {
            get
            {
                return this.count;
            }
        }
        public GenericList(int count)
        {
            if (count > 0)
            {
                this.elements = new T[count];
            }
            else
            {
                throw new ArgumentException("Invalid number of elements !");
            }
        }
        public GenericList()
            : this(4)
        {
        }

        public void Add(T element)
        {
            if (count == elements.Length)
            {
                AutoGrow();
            }

            this.elements[count] = element;
            count++;
        }

        public void InsertAt(T element, int index)
        {
            if (index < count && index > -1)
            {
                if (count == elements.Length)
                {
                    AutoGrow();
                }

                this.count++;

                T[] OldCopy = (T[])this.elements.Clone();

                this.elements[index] = element;
                for (int i = index + 1; i < this.count; i++)
                {
                    this.elements[i] = OldCopy[i - 1];
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index of element to insert !");
            }
        }
        public void RemoveAt(int index)
        {
            if (index < count && index > -1)
            {
                for (int i = index; i < count; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }
                count--;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index of element to remove !");
            }
        }

        public int Find(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public T this[int index]
        {
            get
            {
                if (index < count && index > -1)
                {
                    return this.elements[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index !");
                }

            }
            set
            {
                if (index < count && index > -1)
                {
                    elements[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index !");
                }
            }
        }

        public void Clear()
        {
            int currentLength = this.elements.Length;
            this.elements = new T[currentLength];
            count = 0;
        }

        private void AutoGrow()
        {
            int currentLength = this.elements.Length;
            T[] NewArr = new T[currentLength * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                NewArr[i] = elements[i];
            }

            this.elements = NewArr;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("[");
            for (int i = 0; i < this.count; i++)
            {
                output.Append(this.elements[i].ToString());

                if (i != this.count - 1)
                {
                    output.Append(", ");
                }
            }
            output.Append("]");

            return output.ToString();
        }
    }
}
