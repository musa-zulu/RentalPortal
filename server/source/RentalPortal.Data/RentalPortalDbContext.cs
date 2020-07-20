using Microsoft.EntityFrameworkCore;
using RentalPortal.Data.Models;

namespace RentalPortal.Data
{
    public class RentalPortalDbContext : DbContext
    {
        public RentalPortalDbContext()
        {
        }

        public RentalPortalDbContext(DbContextOptions options) : base(options)
        {
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
    }
}
