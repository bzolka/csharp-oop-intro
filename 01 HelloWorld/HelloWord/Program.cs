﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);

            Console.ReadKey();
        }

    }
}
