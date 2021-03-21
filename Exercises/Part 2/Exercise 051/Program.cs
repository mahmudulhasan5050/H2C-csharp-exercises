using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUnitNumber(9);
      Console.ReadKey();
    }

    // Write your method here:
        public static void PrintUnitNumber(int number) {
          
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
  }
}
