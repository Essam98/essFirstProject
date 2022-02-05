using dotnetWithMosh.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetWithMosh.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; } 

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-53QPPU9; Database=University; Trusted_Connection=True");
            }
        }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<VehicleFeature>()
                        .HasKey(vf => new { vf.VehicleId, vf.FeatureId });

        }
        
    }
}