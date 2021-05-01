using System;
using System.Collections.Generic;

namespace LearningList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customer = new List<string>();
            customer.Add("Kim");
            customer.Add("John");
            customer.Add("Tim");

            Console.WriteLine(customer.Count);

            foreach (var customers in customer)
            {
                Console.WriteLine(customers);
            }

            Console.WriteLine(customer[1]);
        }
    }
}
