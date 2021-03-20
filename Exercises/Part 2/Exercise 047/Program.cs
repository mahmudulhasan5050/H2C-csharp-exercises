using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
            //section 1
            Console.Write("Where to?\n> ");
            int userInputSection1 = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= userInputSection1; i++)
            {
                Console.WriteLine(i);
            }

            //section 2 and 3
            Console.Write("Where to?\n> ");
            int userInputSection2To = Convert.ToInt32(Console.ReadLine());
            Console.Write("Where from?\n> ");
            int userInputSection2From = Convert.ToInt32(Console.ReadLine());
           
            if(userInputSection2To > userInputSection2From) {              
            for(int j = userInputSection2From; j <= userInputSection2To; j++)
            {
                Console.WriteLine(j);
            }
            }
            
            Console.ReadKey(); 
      
    }
  }
}
