﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    internal class Star_Pattern
    {
        public static void Star()
        {
            int rows = 8;


            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
