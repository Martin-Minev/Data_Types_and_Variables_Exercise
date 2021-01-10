using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int counter = 0;

            while (numberOfPersons > 0 && numberOfPersons != 0)
            {
                numberOfPersons -= elevatorCapacity;
                counter++;
            }
            Console.WriteLine($"{counter}");
        }
    }
}
