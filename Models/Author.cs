using System;
using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Api.Data;
using System.Collections.Generic;

namespace Fisher.Bookstore.Api.Data
{
    public class Author{
        public int Id{get; set;}

        public string Name { get; set;}

        public string Bio {get; set;}

        public List<Book> Titles { get; set; }
    }
}