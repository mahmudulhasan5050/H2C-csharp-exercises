using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("How old are you?\n> ");

            int age = Convert.ToInt32(Console.ReadLine());

            bool adult = age >= 18;
            if (adult)
            {
                Console.WriteLine("You're an adult!");
            }
            else
            {
                Console.WriteLine("You're under age!");
            }
            Console.ReadKey();

    }
  }
}
