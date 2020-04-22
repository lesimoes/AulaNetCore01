using System;
using Microsoft.EntityFrameworkCore;
using AulaCore.Models;

namespace AulaCore.database
{
    public class DbContextApplication : DbContext
    {
        public DbContextApplication(DbContextOptions<DbContextApplication> options) : base(options)
        {
        }
        public DbSet<AulaCore.Models.Filme> Filme { get; set; }
    }
}
