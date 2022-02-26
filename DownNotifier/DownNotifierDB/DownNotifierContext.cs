using DownNotifier.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace DownNotifier.Migration
{
    
    public class DownNotifierContext : DbContext
    {
        public virtual DbSet<BaseEntity> BaseEntity { get; set; }
        public virtual DbSet<Site> Site { get; set; }


        //private readonly IActiveUserService _activeUserService;
        public DownNotifierContext(DbContextOptions<DownNotifierContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
