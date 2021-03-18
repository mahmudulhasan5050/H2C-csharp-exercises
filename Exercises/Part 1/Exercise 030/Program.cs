using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Give your percent [0 - 100]:\n> ");
            int number = Convert.ToInt32(Console.ReadLine());
        
            if (number < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if(number <= 49)
            {
                Console.WriteLine("Fail");            
            }
            else if(number <= 59)
            {
                Console.WriteLine("Grade: 1");            
            }
            else if(number <= 69)
            {
                Console.WriteLine("Grade: 2");            
            }
            else if(number <= 79)
            {
                Console.WriteLine("Grade: 3");            
            }
            else if(number <= 89)
            {
                Console.WriteLine("Grade: 4");            
            }
            else if(number <= 100)
            {
                Console.WriteLine("Grade: 5");  
            }          
         
            else
            {
            Console.WriteLine("Outstanding!");
            }
            Console.ReadKey();

    }
  }
}
