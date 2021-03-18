using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true) {
                
            Console.Write("Give a number:\n> ");
            int  answer = Convert.ToInt32(Console.ReadLine());
            int secondPower = 0;

            if(answer == 0)
            {
                break;
            }
            else if(answer > 0)
            {
                    secondPower = answer * answer;
                    Console.WriteLine(secondPower);
            }
            else
            {
                    Console.WriteLine("That is negative");
            }
         
            }
            Console.ReadKey();

    }
  }
}
