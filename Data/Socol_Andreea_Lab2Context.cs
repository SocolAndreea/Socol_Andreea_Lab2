using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Socol_Andreea_Lab2.Models;

namespace Socol_Andreea_Lab2.Data
{
    public class Socol_Andreea_Lab2Context : DbContext
    {
        public Socol_Andreea_Lab2Context (DbContextOptions<Socol_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Socol_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Socol_Andreea_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Socol_Andreea_Lab2.Models.BookCategory>? BookCategory { get; set; }
        public DbSet<Socol_Andreea_Lab2.Models.Category>? Category { get; set; }
        public DbSet<Socol_Andreea_Lab2.Models.Member>? Member { get; set; }
        public DbSet<Socol_Andreea_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
