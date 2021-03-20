using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("> ");
            int firstInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("> ");
            int secondInput = Convert.ToInt32(Console.ReadLine());

            if(firstInput > secondInput)
            {
                Console.WriteLine(firstInput +" is grEater than " + secondInput);
            }
            else if(firstInput < secondInput)
            {
                Console.WriteLine(firstInput + " is less than " + secondInput);
            }
            else
            {
                Console.WriteLine(firstInput + " is equal to " + secondInput);
            }
            Console.ReadKey();
    }
  }
}
