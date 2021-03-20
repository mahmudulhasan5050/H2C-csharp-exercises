using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("> ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int secondPower = userInput * userInput;

            Console.WriteLine(secondPower);
            Console.ReadKey();
    }
  }
}
