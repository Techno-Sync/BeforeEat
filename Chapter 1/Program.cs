﻿using System;

namespace BeforeEat
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = 0b_101100101;
            // uint y = 24;
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // y = y -4294967295;
            // Console.WriteLine(sizeof(uint)+" "+uint.MinValue+" "+uint.MaxValue);
            // // Console.WriteLine(y);
            int? i = null;
            string x = null;
            i = x?.Length ?? 9;
            Console.WriteLine(i==null? 7 : i);
            

        }
    }
}
