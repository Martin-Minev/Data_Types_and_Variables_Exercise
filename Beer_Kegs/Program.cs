using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volumeOfKeg = 0.00;
            string biggestKeg = string.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                volumeOfKeg = Math.PI * Math.Pow(radiusOfKeg, 2) * heightOfKeg;
                if (volumeOfKeg > biggestVolume)
                {
                    biggestVolume = volumeOfKeg;
                    biggestKeg = modelOfKeg;
                }
            }
            Console.WriteLine($"{biggestKeg}");
        }
    }
}
