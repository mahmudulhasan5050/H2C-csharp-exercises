using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("> ");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == 9999)
                {
                    break;
                }
                numbers.Add(input);
            }

            int smallest = numbers[0];
            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine("Smallest number: " + smallest);

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == smallest)
                {
                    Console.WriteLine("Found at index: " + i);
                }
            }
            Console.ReadKey();
    }
  }
}
