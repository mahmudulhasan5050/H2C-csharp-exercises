using System;
using System.IO;


namespace exercise_119
{
  class Program
  {
    public static void Main(string[] args)
    {
            Timer timer = new Timer();

            while (true)
            {
                Console.WriteLine(timer);
                timer.Advance();

                try
                  {    
                    // Wait 100th of a second.       
                    // Sleep(1000) waits one second, if you want to test at slower pace.
                      System.Threading.Thread.Sleep(10);
                    }
   
                // Other half of try-catch pair. 
                   catch (Exception e)
                   {    
                    Console.WriteLine("Error happened: +" + e);   
                }
            }

            Console.ReadKey();
    }
  }
}
