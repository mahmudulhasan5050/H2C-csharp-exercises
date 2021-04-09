using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<TelevisionProgram> television = new List<TelevisionProgram>();


             while (true)
            {
                Console.Write("Name: ");
                string programName = Console.ReadLine();
                
               
                if(programName == "")
                {
                    break;
                }
              
                Console.Write("Duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());
                    
                
            television.Add(new TelevisionProgram(programName, duration));

            }

             Console.WriteLine();
             Console.Write("Program's maximum duration? ");
            int userDuration = Convert.ToInt32(Console.ReadLine());

            foreach(TelevisionProgram tel in television)
            {
                if(tel.duration <= userDuration)
                {
                    Console.WriteLine(tel);
                }
            }

             Console.ReadKey();
    }
  }
}




