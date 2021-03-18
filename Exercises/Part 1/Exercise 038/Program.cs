using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
       int total = 0;

            while (true)
            {
                Console.Write("Give a number:\n> ");
                int number = Convert.ToInt32(Console.ReadLine());

                if(number == 0)
                {
                    break;
                }
                else if(number < 0)
                {
                    total = total + 1;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Total amount of negative numbers: " + total);
            Console.ReadKey();    

    }
  }
}
