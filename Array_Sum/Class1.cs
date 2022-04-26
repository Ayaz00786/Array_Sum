using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Sum
{
    internal class Class1
    {
        public static void Array()
        {
            int[] array = new int[10];

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number in Position {0}:", i);
                int num = int.Parse(Console.ReadLine());
                array[i] = num;
                sum = sum + array[i];
            }
            Console.WriteLine("\nSum Of Total Number Is: " + sum);
            Console.ReadLine();
        }
    }
}
