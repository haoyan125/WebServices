using System.Data.Entity.ModelConfiguration.Conventions;

namespace HY.MiPlate.Services.Repository.DBContext
{
    using System.Data.Entity;
    public class MiPlateWriteDbContext : DbContext
    {
        public MiPlateWriteDbContext() : base("MiPlateWriteDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
