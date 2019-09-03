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
                //Book b = new Book();
                Console.WriteLine("welcome To Online Book Shopping");
                
                var purchasedBook = new Book();
                Console.WriteLine("Pl Enter Book Title");
                purchasedBook.Title = Console.ReadLine();
                Console.WriteLine("Pl Enter Book Price");
                purchasedBook.Price = Convert.ToDouble(Console.ReadLine());
                myBook.Add(purchasedBook);

                Console.WriteLine("Continue Shopping yes or no");
                var choice = Console.ReadLine();

                if (choice == "no")
                {
                    var total = 0.0;
                    isShopping = false;
                    Console.WriteLine("Here Are Your Books");
                    foreach (var Book in myBook)
                    {
                        total += Book.Price;
                        Console.WriteLine("Title  " + Book.Title + "  Price   " + Book.Price);
                    }

                    Console.WriteLine("        Hello Total Price is  Wishing You coming soon    " + total);

               }
            }

        }
    }
}

    


