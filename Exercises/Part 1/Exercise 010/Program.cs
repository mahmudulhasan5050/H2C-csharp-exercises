using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
          
           Console.Write("I will tell a story, but I need some information.\n"+
                "Give a name for main character:\n" + "> ");
            string name = Console.ReadLine();
            Console.Write("Give the character a profession:\n" +"> ");
            string profession = Console.ReadLine();

            Console.Write("Here is the story:\n"+
                "Once upon a time there was a "+ profession +" called "+ name +
                "\nOn her way to work, "+ name + " often poundered what being "+ profession + 
                " meant to them.\n"+
                "When you work as a "+ profession +" you meet interesting people.\n"
                + name +" enjoys their work as "+ profession +", The end.");

            Console.ReadKey();
        }
    }
}
