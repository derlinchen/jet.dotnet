using jet.Bean.model;
using jet.Bean.vo;
using Microsoft.EntityFrameworkCore;

namespace jet.Config
{
    public class EFCoreContext : DbContext
    {
        public EFCoreContext(DbContextOptions<EFCoreContext> options) : base(options)
        {
        }

        public DbSet<BaseDic> BaseDic { get; set; }
        public DbSet<BaseDicVo> BaseDicVo { get; set; }
    }
}
