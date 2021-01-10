using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int amount = int.Parse(Console.ReadLine());
                total += amount;

                if (total > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    total -= amount;
                }
            }
            Console.WriteLine(total);
        }
    }
}
