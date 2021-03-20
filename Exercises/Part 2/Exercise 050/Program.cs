using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("How many times?\n> ");
            int userInput = Convert.ToInt32(Console.ReadLine());


            // Call your method here:
            PrintPhrase(userInput);
            Console.ReadKey();
    }

    // Write your method here:
    public static void PrintPhrase(int times) {
          
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine("In a hole in the ground there lived a method");
            }
    }
  }
}
