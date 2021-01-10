using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int dayCount = 0;
            int totalSpicePerDay = 0;
            int sum = 0;
            while (startingYield >= 100)
            {
                totalSpicePerDay = startingYield - 26;
                sum += totalSpicePerDay;
                dayCount++;
                startingYield -= 10;
            }
            if (startingYield < 100)
            {

                if (sum>26)
                {
                    sum = sum - 26;
                }
                
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(sum);
        }
    }
}
