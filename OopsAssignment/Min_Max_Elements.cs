using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssignment
{
    internal class Min_Max_Elements
    {
        public static void Min_Max()
        {
            Console.Write("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Max = arr[0];
            int Min = arr[0];

            if (Max > Min)
            {
                Max = arr[0];
            }
            if (Min < Max)
            {
                Min = arr[0];
            }

            Console.WriteLine("Maximum element: " + Max);
            Console.WriteLine("Minimum element: " + Min);

        }
    }
}
