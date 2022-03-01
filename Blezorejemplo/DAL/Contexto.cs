using Microsoft.EntityFrameworkCore;
using Blezorejemplo.Entidades;
using Blezorejemplo.DAL;

namespace Blezorejemplo.DAL
{
   public class Contexto : DbContext
    { 

        public DbSet<Productos> Productos {get; set;}
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = DATA\Data.db");
        }
    }
}