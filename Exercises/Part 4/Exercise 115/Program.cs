using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
             int resultCube = 0;
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                
                if(input == "end")
                {
                    break;
                }
                else
                {
                    int inputInt = Convert.ToInt32(input);
                    resultCube = inputInt * inputInt * inputInt;
                    Console.WriteLine(resultCube);
                }
            }

            Console.ReadKey();
    }
  }
}
