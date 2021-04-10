using System;

namespace ClassesAndObjectsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();
            book1.title = "Love Me";
            book1.author = "Koko Padgett";
            book1.pages = 389;


            Books book2 = new Books();
            book2.title = "Ring Me";
            book2.author = "Tony Padgett";
            book2.pages = 217;


            Console.WriteLine(book1.title);
            
           
            



        }
    }
}
