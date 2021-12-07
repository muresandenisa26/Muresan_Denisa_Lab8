using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muresan_Denisa_Lab8.Models;

namespace Muresan_Denisa_Lab8.Data
{
    public class Muresan_Denisa_Lab8Context : DbContext
    {
        public Muresan_Denisa_Lab8Context (DbContextOptions<Muresan_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Muresan_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Muresan_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Muresan_Denisa_Lab8.Models.BookCategory> BookCategory { get; set; }
        public IEnumerable<object> Category { get; internal set; }
    }
}
