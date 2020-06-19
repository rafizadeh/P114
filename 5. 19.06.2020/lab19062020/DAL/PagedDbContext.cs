using lab19062020.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab19062020.DAL
{
    public class PagedDbContext : DbContext
    {
        public PagedDbContext() : base("PagedDbContext")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}