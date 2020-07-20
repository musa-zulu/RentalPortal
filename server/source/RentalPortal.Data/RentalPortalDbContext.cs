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

        public virtual DbSet<Status> Statuses { get; set; }
    }
}
