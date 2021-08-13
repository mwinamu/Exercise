using System;
using System.Numerics;
using Exercise01;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert to words: ");
            string numb= Console.ReadLine().Replace(",","").Trim();
            Console.WriteLine(numb);
            double n = double.Parse(numb);
            Console.WriteLine("{0}", n.Towards());
        }
    }
}
