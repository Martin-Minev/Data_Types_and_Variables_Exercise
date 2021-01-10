using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestValue = 0;
            int biggestSnowballSnow = 0;
            int biggestSnowballTime = 0;
            int biggestSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                double snowDividedByTime = snowballSnow / snowballTime;
                double snowballValue = Math.Pow(snowDividedByTime, snowballQuality);

                if (snowballValue > biggestValue)
                {
                    biggestValue = snowballValue;

                    biggestSnowballSnow = snowballSnow;
                    biggestSnowballTime = snowballTime;
                    biggestSnowballQuality = snowballQuality;

                }
            }
            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {biggestValue} ({biggestSnowballQuality})");
        }
    }
}
