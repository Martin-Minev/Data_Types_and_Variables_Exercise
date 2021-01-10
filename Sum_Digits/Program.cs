using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // int digit = (int)Char.GetNumericValue(input[i]);
                int digit = int.Parse(input[i].ToString());
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
