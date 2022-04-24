using jet.Bean.model;
using Microsoft.EntityFrameworkCore;

namespace jet.Config
{
    public class EFCoreContext : DbContext
    {
        public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
        {
        }

        public DbSet<BaseDic> BaseDics { get; set; }
    }
}
