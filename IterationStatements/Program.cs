using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Exercie 1
            
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine($"{i}");
            } */



            /*Exercise 2

            var numbers = new List<int>();
            var num = 0;

            do
            {
                num++;
                numbers.Add(num);
                Console.WriteLine($"{num}");
            }
            while (num < 10);  */


            //var numbers1 = new List<int>();
            //var num1 = 0;

            //do
            //{
            //    num1++;
            //    numbers1.Add(num1);
            //    Console.WriteLine($"{num1}");
            //}
            //while (num1 < 100);


            //var numbers2 = new List<int>();
            //int i = 0;
            //while (i < 200)
            //{
            //    i++;
            //    numbers2.Add(i);
            //    Console.WriteLine($"{i}");
            //}


            //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine($"{num}");
            //}


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            var numbers = new List<int>(); 
            for (int i = 199; i >= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{i}");
                Console.WriteLine(" ");
            }

            //------------End of exercise
        }
    }
}
