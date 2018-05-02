using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Demo.Model;

namespace Demo.Dal
{
    public class DemoContext : DbContext
    {
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DemoContext() : base("Demo")
        {

        }

        static DemoContext()
        {

            using (DemoContext db = new DemoContext())
            {
                
                if (!db.Database.Exists())
                {
                    // Database initialize
                    Database.SetInitializer<DemoContext>(new DemoInitializer());
                    db.Database.Initialize(false);
                }
                else
                {
                    if (!db.Database.CompatibleWithModel(true))
                    {
                        // Database initialize
                        Database.SetInitializer<DemoContext>(new DemoInitializer());
                        db.Database.Initialize(false);
                    }
                    else
                    {
                        // Not initialize database
                        Database.SetInitializer<DemoContext>(null);
                    }
                }
            }

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention, the generated tables  
            // will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Cliente>()
                .HasRequired<Documento>(c => c.Documento)
                .WithMany()
                .WillCascadeOnDelete(false);

        }

           
    }

}
