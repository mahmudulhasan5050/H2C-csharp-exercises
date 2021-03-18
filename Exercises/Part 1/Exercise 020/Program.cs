using System;

namespace exercise_20
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

            int mutiply = firstNumber * secondNumber;

            Console.WriteLine(firstNumber +" * "+ secondNumber+" = "+ mutiply);
            Console.ReadKey();

    }
  }
}
