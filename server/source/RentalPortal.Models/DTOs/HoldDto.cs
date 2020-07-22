using System;

namespace RentalPortal.Models.DTOs
{
    public class HoldDto
    {
        public Guid HoldId { get; set; }
        public DateTime HoldPlaced { get; set; }
        public RentalAssetDto RentalAssetDto { get; set; }
        public RentalClubCardDto RentalClubCardDto { get; set; }
    }
}
