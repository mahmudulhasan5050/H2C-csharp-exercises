using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
      Console.ReadKey();
    }

    // Write your method here:
    public static int Smallest(int number1, int number2)
        {
            int smallest = 0;
            if(number1 < number2)
            {
                smallest = number1;
            }
            else
            {
                smallest = number2;
            }
            return smallest;
        }
  }
}
