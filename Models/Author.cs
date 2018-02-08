using System;
using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Api.Models;

namespace Fisher.Bookstore.Api.Models
{
    public class Author{
        public int Id{get; set;}

        public string Name { get; set;}
    }
}