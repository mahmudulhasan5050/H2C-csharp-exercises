using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
            PrintStars(5);
            PrintSpaces(5);

            Console.WriteLine("");

            PrintRightTriangle(4);

            Console.WriteLine("");
            ChristmasTree(4);
            Console.ReadKey();
    }

    public static void PrintStars(int number)
    {
  
           for(int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
              
    }

    public static void PrintSpaces(int number)
    {
           for(int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
    }

    public static void PrintRightTriangle(int size)
    {
           
              for(int i = 0; i < size; i++) { 

                for(int j = 0; j < size - i; j++)
                {
                Console.Write(" "); 
                 
                }
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
              
             }   
            
    }

    public static void ChristmasTree(int height)
    {
            
  


    }
  }
}
