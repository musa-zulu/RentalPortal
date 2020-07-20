using System;

namespace RentalPortal.Data.Models
{
    public class Hold : EntityBase
    {
        public Guid HoldId { get; set; }
        public DateTime HoldPlaced { get; set; }
        public virtual RentalAsset RentalAsset { get; set; }
        public virtual RentalClubCard RentalClubCard { get; set; }
    }
}
