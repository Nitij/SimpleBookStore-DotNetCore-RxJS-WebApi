using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
    }
}
