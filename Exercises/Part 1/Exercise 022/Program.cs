using System;

namespace exercise_22
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

            Console.Write("Give the third number!\n> ");
            string thirdInput = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(thirdInput);

            double averageNormal = (firstNumber + secondNumber + thirdNumber)/3.0;
            string averageFormat = string.Format("{0:0.0}", averageNormal);

            Console.WriteLine("The average is " + averageFormat);
            Console.ReadKey();

    }
  }
}
