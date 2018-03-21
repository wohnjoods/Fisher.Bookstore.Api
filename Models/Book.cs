using System;
using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Api.Data;

namespace Fisher.Bookstore.Api.Data
{
    public class Book{
        public int Id{get; set;}

        public string Title { get; set;}

        public Author Author { get; set;}

        public string ISBN { get; set;}

        public DateTime PublishDate { get; set;}

        public string Publisher { get; set;}
    }
}