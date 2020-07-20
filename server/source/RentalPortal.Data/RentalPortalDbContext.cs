using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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


    }
}
