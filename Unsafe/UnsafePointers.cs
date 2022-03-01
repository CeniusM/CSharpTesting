using System;

namespace MyUnsafe.Pointers
{
    class Test
    {
        public unsafe static void Start()
        {
            int a = 1;
            int* p = &a;

            Console.WriteLine(a);
            *p += 2;
            Console.WriteLine(a);
            *p = *p >> 1;
            Console.WriteLine(a);

            float f = 1.5f;
            long* pointer = (long*)&f;

            Console.WriteLine(Convert.ToString(*pointer, 2));
            Console.WriteLine(f);
            *pointer = *pointer >> 1;
            Console.WriteLine(Convert.ToString(*pointer, 2));
            Console.WriteLine(f);

        }
    }
}