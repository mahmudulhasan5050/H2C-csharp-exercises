using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();

            while (true)
            {
                Console.Write("First Name:\n> ");
                string firstName = Console.ReadLine();
                
               
                if(firstName == "")
                {
                    break;
                }
              
                Console.Write("Last Name:\n> ");
                string lastName = Console.ReadLine();
                Console.Write("Identification number:\n> ");
                string identificationNumber = Console.ReadLine();
                    
                
            list.Add(new PersonalInformation(firstName, lastName, identificationNumber));

            }

            Console.WriteLine();
            foreach(PersonalInformation li in list)
            {
                Console.WriteLine(li.firstName + " " + li.lastName);
            }

            Console.ReadKey();
    }
  }
}




