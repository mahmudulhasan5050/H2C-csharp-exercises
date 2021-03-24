using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
     Console.ReadKey();
    }

    // Write your method here:
    public static int Greatest(int number1, int number2, int number3)
        {
            int greatest = 0;
            if(number1 > number2 && number1 > number3)
            {
                greatest = number1;
            }
            else if(number2 > number1 && number2 > number3)
            {
                greatest = number2;
            }
            else
            {
                greatest = number3;
            }
            return greatest;
        }
  }
}
