using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("Your speed:\n> ");

            int speed = Convert.ToInt32(Console.ReadLine());

            if(speed > 120)
            {
                Console.WriteLine("Speeding!");
            }
      
            Console.ReadKey();
    }
  }
}
