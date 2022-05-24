using Booksagram.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booksagram.DBContext
{
    public class BooksagramDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);
            if(optionBuilder.IsConfigured == false)
            {
                optionBuilder.UseSqlServer("Server=.;Database=BooksagramDataBase;Integrated security=true;");
            }     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasOne(t => t.User).WithMany(u => u.Books).HasForeignKey(t => t.UserId);
        }
    }
}
