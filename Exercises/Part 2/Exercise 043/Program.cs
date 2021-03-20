using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("> ");
            int firstInput = Convert.ToInt32(Console.ReadLine());

           if(firstInput < 0)
            {
                firstInput = firstInput * (-1);
                Console.WriteLine(firstInput);
            }
           else
            {
                Console.WriteLine(firstInput);
            }
           
            Console.ReadKey();
      
    }
  }
}
