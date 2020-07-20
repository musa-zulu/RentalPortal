using System;

namespace RentalPortal.Models.DTOs
{
    public class RentalDto
    {
        public Guid RentalId { get; set; }
        public DateTime RentedOutSince { get; set; }
        public DateTime RentedOutUntil { get; set; }
        public RentalAssetDto RentalAssetDto { get; set; }
        public RentalClubCardDto RentalClubCardDto { get; set; }
    }
}
