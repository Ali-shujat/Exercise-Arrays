using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Exercise 3 and 4: Arrays ");
            Console.WriteLine("Please enter 5 integer numbers");
            // Reverse array -- Create a program to ask the user for 5 numbers, store them in an array and show them in reverse order.

            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(a);
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
            Console.ReadKey();

            // Array, even numbers -- Write a C# program to ask the user for 10 integer numbers and display the even ones.
            Console.WriteLine("Please enter 10 integer numbers");
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
