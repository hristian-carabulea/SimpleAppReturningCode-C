﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppReturningCode
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            // Wait for Enter key to be pressed before shutting down.
            // Console.ReadLine();

            // Return an arbitrary error code.
             return 0; // succeeded
            // return -1; // failed
        }
    }
}
