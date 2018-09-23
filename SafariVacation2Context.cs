using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using take_the_safari_online.Models;

namespace take_the_safari_online
{
    public partial class SafariVacation2Context : DbContext
    {
        public SafariVacation2Context()
        {
        }

        public SafariVacation2Context(DbContextOptions<SafariVacation2Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("server=localhost;username=postgres;password=mark;database=SafariVacation2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }

        public DbSet<SeenAnimals> SeenAnimals { get; set; }
    }
}
