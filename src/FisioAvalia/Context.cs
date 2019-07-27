using System.Data.Entity.ModelConfiguration.Conventions;
using FisioAvalia.Models.Tables;
using System.Data.Entity;


namespace FisioAvalia.DataBd
{
    class Context : DbContext
    {

        public Context() : base("fisio")
        {

        }

        public DbSet<Profile> Profiles { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
