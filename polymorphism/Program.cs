using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInts = AddToInt(7, 13);

            Console.WriteLine("Int: " + addedSumOfInts);
        }

        static int AddToInt(int x, int y)
        {
            return x + y;
        }
    }
}
