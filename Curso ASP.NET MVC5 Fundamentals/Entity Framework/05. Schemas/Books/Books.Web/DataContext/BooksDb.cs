using Books.Entities;
using System.Data.Entity;
using System.Diagnostics;

namespace Books.Web.DataContext
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("DefaultConnection")
        {
            Database.Log = sql => Debug.Write(sql); //veja no output
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Todas entidades mapeadas como tabelas terão esse schema library
            modelBuilder.HasDefaultSchema("library");
            base.OnModelCreating(modelBuilder);
        }
    }
}