﻿namespace Peskit.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public string ImageUrl { get; set; }

        public string AuthorId { get; set; }

        public DateTime DateTime { get; set; }

        public Author Author { get; set; }
    }
}
