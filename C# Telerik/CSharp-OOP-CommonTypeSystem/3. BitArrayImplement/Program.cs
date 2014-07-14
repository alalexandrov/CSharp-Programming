using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BitArrayImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            BitArray64 bitArr = new BitArray64(123456789);
            BitArray64 bitArr2 = new BitArray64(ulong.MaxValue);

            Console.WriteLine("Value: {0}", bitArr.Value);
            Console.WriteLine("Bits from first position:");

            foreach (var bit in bitArr)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine("Equals: {0}", bitArr.Equals(bitArr2));
            Console.WriteLine("Equals: {0}", bitArr.Equals(bitArr));

            Console.WriteLine("'==': {0}", bitArr == bitArr2);
            Console.WriteLine("'!=': {0}", bitArr != bitArr2);

            Console.WriteLine("HashCode: {0}", bitArr.GetHashCode());

            bitArr[3] = 1;
            Console.WriteLine("Setting bit at position 3 to '1'");
            Console.WriteLine("Bit at position 3 is: {0}", bitArr[3]);
            Console.WriteLine("Value: {0}", bitArr.Value);
        }
    }
}
