using Microsoft.EntityFrameworkCore;
using RentalPortal.Data.Models;
using System.Threading.Tasks;

namespace RentalPortal.Data
{
    public interface IRentalPortalDbContext
    {
        DbSet<Hold> Holds { get; set; }
        DbSet<Rental> Rentals { get; set; }
        DbSet<Patron> Patrons { get; set; }
        DbSet<Status> Statuses { get; set; }
        DbSet<AssetType> AssetTypes { get; set; }
        DbSet<BranchHours> BranchHours { get; set; }
        DbSet<RentalAsset> RentalAssets { get; set; }
        DbSet<RentalBranch> RentalBranches { get; set; }
        DbSet<RentalHistory> RentalHistories { get; set; }
        DbSet<RentalClubCard> RentalClubCards { get; set; }

        Task<int> SaveChangesAsync();
    }
    public class RentalPortalDbContext : DbContext, IRentalPortalDbContext
    {
        public RentalPortalDbContext()
        {
        }
        public RentalPortalDbContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        public virtual DbSet<Hold> Holds { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Patron> Patrons { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<BranchHours> BranchHours { get; set; }
        public virtual DbSet<RentalAsset> RentalAssets { get; set; }
        public virtual DbSet<RentalBranch> RentalBranches { get; set; }
        public virtual DbSet<RentalHistory> RentalHistories { get; set; }
        public virtual DbSet<RentalClubCard> RentalClubCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("DataSource=app.db");
            }

        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
