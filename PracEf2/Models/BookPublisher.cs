using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracEf2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        //public int PublisherId { get; set; }
        //public Publisher Publisher { get; set; }

        public ICollection<Publisher> Publishers { get; set; }

    }

    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}