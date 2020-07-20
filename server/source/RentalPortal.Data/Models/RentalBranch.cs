using System;
using System.Collections.Generic;

namespace RentalPortal.Data.Models
{
    public class RentalBranch : EntityBase
    {
        public Guid RentalBranchId { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime OpenDate { get; set; }
        public Guid AddressId { get; set; }
        public Guid TelephoneId { get; set; }

        public virtual IEnumerable<Patron> Patrons { get; set; }
        public virtual IEnumerable<RentalAsset> RentalAssets { get; set; }

    }
}
