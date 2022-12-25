using System;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum;
            Console.WriteLine("Enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last number");
            int last = int.Parse(Console.ReadLine());
            for (i = first; i <= last; i++)
            {
                sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == 1)
                    Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
