using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_mvc.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int PublisherId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Book(string isbn, string title, int yearPublished, int publisherId, double price, string description)
        {
            ISBN = isbn;
            Title = title;
            YearPublished = yearPublished;
            PublisherId = publisherId;
            Price = price;
            Description = description;
        }
    }
}