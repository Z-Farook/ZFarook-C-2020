using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Chapter2
{
    internal static class BigIntegerUse
    {
        /**
         * The BigInteger type is an IMMUTABLE type that represents an arbitrarily large integer
         * whose value in theory has no upper or lower bounds. 
         */
        internal static void PrintBigInteger()
        {
            BigInteger x = 1;
            BigInteger y = 1;
            Console.WriteLine(x);
            int counter = 0;
            while (true)
            {
                if (counter++ % 100000 == 0 )
                {
                    Console.WriteLine(y);
                }
                BigInteger next = x + y;
                x = y;
                y = next;
            }
        }

    }
}
