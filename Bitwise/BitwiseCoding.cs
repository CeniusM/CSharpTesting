using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Mytesting
    {
        public static void Test()
        {
            int myByte = 0b_10000100;

            Console.WriteLine(myByte << 0b1);

            Console.WriteLine(Convert.ToString(myByte, toBase: 2));

            int myByte2 = (myByte << 1);
            myByte2 <<= 1;

            Console.WriteLine(myByte2);

            Console.WriteLine(Convert.ToString(myByte2, toBase: 2));
            var color = 0b_0100 ^ 4; // = 4 ^ 4

            P(color);

            Console.ReadLine(); //
            Console.ReadLine(); //
            Console.ReadLine(); //
        }

        /// <summary>
        /// Returns true if 3rd last bit is set.
        /// </summary>
        public static bool IsWhite(int piece)
        {
            // what if piece is 0101
            // 4 =              0100

            /*
            piece = 1111
            4     = 0100
            output= 0100

            output == 4; true
            */
            return (piece & 4) == 4;
        }

        /// <summary>
        /// Returns true if the nth last bit (by position) is set.
        /// Examples:
        /// (5, 0) => true
        /// (5, 1) => false
        /// </summary>
        public static bool IsSet(int value, int position)
        {
            return (value & (0b1 << position)) != 0;
        }

        public static void P(int v) => Console.WriteLine(Convert.ToString(v, toBase: 2));
    }
}

/*
| = or
^ = xor
& = and
~ = not, unary operator

or
10110101
10010101=
10110101

xor
00110101
10101011=
10011010

and
10110101
10010101=
10010001

not
10110101=
01001010
*/