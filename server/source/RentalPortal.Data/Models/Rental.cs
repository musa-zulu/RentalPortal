using System;

namespace RentalPortal.Data.Models
{
    public class Rental : EntityBase
    {
        public Guid RentalId { get; set; }
        public RentalAsset RentalAsset { get; set; }
        public RentalClubCard RentalClubCard { get; set; }
        public DateTime RentedOutSince { get; set; }
        public DateTime RentedOutUntil { get; set; }
    }
}
