using Microsoft.EntityFrameworkCore;

namespace AulaMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AulaMVC;Integrated Security=True");
        }
    }
}