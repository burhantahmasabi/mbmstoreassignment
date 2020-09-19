using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Book> books = new List<Book>();
            IEnumerable<MusicCD> musicCDs = new List<MusicCD>();

            var book1 = new Book("Steve turner", "a hard days write", 150M, 2005);
            book1.Publisher = "it books (2005)";

            var book2 = new Book("Steve turner", "a hard days write", 150M, 2005);
            book1.Publisher = "it books (2005)";

            var book3 = new Book("Steve turner", "a hard days write", 150M, 2005);
            book1.Publisher = "it books (2005)";


            var cd1 = new MusicCD("corinne bailey rae", "the sea", 25.98M, 2010);
            var cd2 = new MusicCD("corinne bailey rae", "the sea", 25.98M, 2010);
            var cd3 = new MusicCD("corinne bailey rae", "the sea", 25.98M, 2010);


            return View();
        }
    }
}
