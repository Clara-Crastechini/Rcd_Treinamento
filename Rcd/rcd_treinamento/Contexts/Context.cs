using Microsoft.EntityFrameworkCore;
using rcd_treinamento.Domains;

namespace rcd_treinamento.Contexts
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Personagem> Personagem { get; set; }






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE12-S28\\SQLEXPRESS; DataBase=Db_Rdc; User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
