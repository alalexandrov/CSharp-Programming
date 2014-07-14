using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BitArrayImplement
{
    class BitArray64 : IEnumerable<int>
    {
        public ulong Value { get; set; }

        public BitArray64(ulong value)
        {
            this.Value = value;
        }
        public int[] GetBinaryArr()
        {
            int[] bits = new int[64];
            ulong number = this.Value;

            for (int i = bits.Length - 1; i >= 0; i--)
            {
                bits[i] = (int)(number % 2);
                number /= 2;
            }

            return bits;
        }
        private ulong GetNewValue(int[] bits)
        {
            ulong value = 0;
            int bitsCount = bits.Length;
            for (int i = 0; i < bitsCount; i++)
            {
                if (bits[bitsCount - 1 - i] == 1)
                {
                    value += (ulong)Math.Pow(2, i);
                }
            }

            return value;
        }
        public override bool Equals(Object obj)
        {
            BitArray64 arr = obj as BitArray64;

            if (arr == null)
                return false;
            if (!Object.Equals(this.Value, arr.Value))
                return false;

            return true;
        }
        public override int GetHashCode()
        {
            return this.Value.GetHashCode() ^ 27;
        }
        public int this[int index]
        {
            get
            {
                int[] bits = this.GetBinaryArr();
                if (index >= 0 && index < bits.Length)
                {
                    return bits[bits.Length - 1 - index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index !");
                }
            }
            set
            {
                int[] bits = this.GetBinaryArr();
                if (index >= 0 && index < bits.Length)
                {
                    if (value == 0 || value == 1)
                    {
                        bits[bits.Length - 1 - index] = value;
                        this.Value = GetNewValue(bits);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid bit value !");
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index !");
                }
            }
        }
        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }
        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
