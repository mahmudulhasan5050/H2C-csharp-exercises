using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> books = new List<Book>();

           while (true)
            {
                Console.Write("Name: ");
                string titleBook = Console.ReadLine();
                
               
                if(titleBook == "")
                {
                    break;
                }
              
                Console.Write("Pages: ");
                int pageBook = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int yearPublication = Convert.ToInt32(Console.ReadLine());                    
                
            books.Add(new Book(titleBook,pageBook,yearPublication));

            }

           Console.Write("What information will be printed? ");
            string title = Console.ReadLine();

            if(title == "everything") { 
           foreach(Book bo in books)
            {
                Console.WriteLine(bo);
            }
           }
            else if(title == "title")
            {
            foreach(Book bo in books)
            {
                Console.WriteLine(bo.title);
            }
            }
           Console.ReadKey();
    }
  }
}




