using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Give the first string:\n> ");
            string firstWord = Console.ReadLine();

            Console.Write("Give the second string:\n> ");
            string secondWord = Console.ReadLine();
            

            if(firstWord == secondWord)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }
            Console.ReadKey();

    }
  }
}
