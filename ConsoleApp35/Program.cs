using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp35
{
   
    class Program
    {
        static void Main(string[] args)
        {
            bool isShopping = true;
            List<Book> myBook = new List<Book>();
            while (isShopping)
            {
                Book b = new Book();
                var purchaseBook = new Book();
                b.Title = Console.ReadLine();
                b.Price = Convert.ToDouble(Console.ReadLine());
                myBook.Add(purchaseBook);

                Console.WriteLine("Continue Shopping yes or no");
                var choice = Console.ReadLine();

                if (choice == "no")
                    isShopping = false;


         }

            Console.WriteLine("Here Are Your Books");

            foreach (var Book in myBook)
                Console.WriteLine("Title  " + Book.Title + "  Price   " + Book.Price);




        }
    }

    

}
