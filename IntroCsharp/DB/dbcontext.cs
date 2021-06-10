using Microsoft.EntityFrameworkCore;
using IntroCsharp.Models;
using System.Configuration;


namespace dbcontext.DB
{
    public class TicDB : DbContext {
        
        public TicDB(DbContextOptions<TicDB> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}