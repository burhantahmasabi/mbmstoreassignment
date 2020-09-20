using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;



namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        //properties 
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();


        //empty Construtor
        static Repository() 
        {
            //(Created all objects here and add them to Products and Invoices)
           
            // Books
            Book b1 = new Book("Steve Turner", "A hard day's write", 150M, 2005)
            {
                Publisher = "It Books",
                ISBN = "9781858680330",
                ImageFileName = "steve.jpg"
            };
            

            Book b2 = new Book("Georg martin", "With a Little Help from My Friends: The Making of Sgt. Pepper", 1800, 1995)
            {
                Publisher = "Little Brown & Co",
                ISBN = "978-0316547833",
                ImageFileName = "georg.jpg"
            };
            
           
            // Movies
            Movie jungleBook = new Movie("Jungle Book", 160.50m)
            {
                ImageFileName = "JungleBook.jpg",
                Director = "Jon Favreau"
            };
            

            Movie tarzan = new Movie("tarzan", 75m)
            {
                ImageFileName = "tarzan.jpg",
                Director = "Steve jacobsen"
            };
           

            Movie frozen = new Movie("Frozen", 60m)
            {
                ImageFileName = "frozen.jpg",
                Director = "Mikkel Schmidt"
            };
           

            //MusicCD
            MusicCD cd1 = new MusicCD("The Beatles", "Abbey Road (Remastered)", 128M, 2009)
            {
                Label = "EMI",
                ImageFileName = "beatles.jpg"
            };

            Track t1 = new Track("come togther", new TimeSpan(0, 2, 0));
            Track t2 = new Track("come togther", new TimeSpan(0, 2, 0));
            Track t3 = new Track("come togther", new TimeSpan(0, 2, 0));
            Track t4 = new Track("come togther", new TimeSpan(0, 2, 0));

            cd1.AddTrack(t1);
            cd1.AddTrack(t2);
            cd1.AddTrack(t3);
            cd1.AddTrack(t4);

            //products added
            Products.Add(b1);
            Products.Add(b2);
            Products.Add(jungleBook);
            Products.Add(tarzan);
            Products.Add(frozen);
            Products.Add(cd1);

            //costumer
            Customer cust1 = new Customer(1, "Burhan", "TAhmasbi", "Lundingsgade227", "8000", "Aarhus");
            Customer cust2 = new Customer(2, "Jane", "Doe", "Otherstreet 13", "2000", "Othercity");
            Customer cust3 = new Customer(3, "Moe", "Lester", "Shadystreet 69", "4200", "Shadycity");

            //invoice
            Invoice invoice1 = new Invoice(1, new DateTime(), cust1);
            invoice1.AddOrderItem(cd1, 2);
            Invoices.Add(invoice1);

            Invoice invoice2 = new Invoice(2, new DateTime(), cust2);
            invoice2.AddOrderItem(tarzan, 2);
            invoice2.AddOrderItem(b1, 2);
            Invoices.Add(invoice2);

            Invoice invoice3 = new Invoice(3, new DateTime(), cust3);
            invoice3.AddOrderItem(frozen, 1);
            invoice3.AddOrderItem(b2, 2);
            invoice3.AddOrderItem(jungleBook, 1);
            Invoices.Add(invoice3);
      
        }
    }
}
