using System.Data.Entity;
using Books.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Books.Web.DataContext
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {}

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Todas entidades mapeadas como tabelas terão esse schema identity
            modelBuilder.HasDefaultSchema("identity");
            base.OnModelCreating(modelBuilder);
        }
    }
}