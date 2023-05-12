using System;
using System.Net.Security;

namespace GenericSolution
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello Generic Problem and Maximum Number Program");

            MaxValue maxValue = new MaxValue();


            Console.WriteLine(" Case 1:");
            maxValue.FindMaxInt(50, 15, 9);


            Console.WriteLine(" Case 2:");
            maxValue.FindMaxInt(15, 50, 9);


            Console.WriteLine(" Case 3:");
            maxValue.FindMaxInt(15, 9, 50);

           
        }
    }
}
