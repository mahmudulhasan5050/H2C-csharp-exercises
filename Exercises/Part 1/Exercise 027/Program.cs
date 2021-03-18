using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Give a number:\n> ");

            int numberInput = Convert.ToInt32(Console.ReadLine());

            bool positive = numberInput > 0;
            if (positive)
            {
                Console.WriteLine("It is positive");
            }
            else
            {
                Console.WriteLine("It is not positive");
            }
            Console.ReadKey();
    }
  }
}
