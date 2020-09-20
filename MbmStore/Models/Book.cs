﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        
        public string ISBN { get; set; }
    

        public Book() { }
        public Book(string author, string title, decimal price, short published) : base(title, price)
        {
            Author = author;
            Published = published;
            ISBN = "1234567890";
        }

    }
}
