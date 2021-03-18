using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number!\n> ");
            string firstInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstInput);

            Console.Write("Give the second number!\n> ");
            string secondInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondInput);

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The sum is "+ sum);
            Console.ReadKey();
    }
  }
}
