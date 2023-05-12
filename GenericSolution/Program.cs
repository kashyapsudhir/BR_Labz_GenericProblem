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
            maxValue.FindMaxFloat(50, 15, 9);


            Console.WriteLine("Case 2(float):");
            maxValue.FindMaxFloat(3.4f, 1.4f, 2.5f);


        }
    }
}
