using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
         PrintStars(5);
         PrintStars(3);
         PrintStars(9);

         Console.WriteLine("");

         PrintSquare(4);
         
         Console.WriteLine("");
         
         PrintRectangle(17,3);
         
         Console.WriteLine("");
        
         PrintTriangle(4);
            
         Console.ReadKey();
    }


    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      for(int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
               Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
    }

    public static void PrintRectangle(int width, int height)
    {
              for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
    }

    public static void PrintTriangle(int size)
    {
          for(int i = 0; i < size; i++)
            {
                
                for(int j = 0; j <= i; j++)
                {
                Console.Write("*");    
                }
                Console.WriteLine(" ");
                
            }
    }
  }
}
