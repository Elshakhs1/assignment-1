﻿using System;
using System.Linq;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {

            var prices = new[] { 12, 15, 30, 10, 5 , 20};



            var max = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > max)
                {
                    max = prices[i];
                }
            }
            Console.WriteLine(max);

            var min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
            }
            Console.WriteLine(min);


            var sum = 0d; // d for double
            for (int i = 0; i < prices.Length; i++)
            {
                sum += prices[i];
            }
            Console.WriteLine(sum);
            for (int i = 0; i < prices.Length; i++)
            {


            }

            var average = prices.Average();
            Console.WriteLine(average);



        }


    }
}
