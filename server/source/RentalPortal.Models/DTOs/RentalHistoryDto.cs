using System;

namespace RentalPortal.Models.DTOs
{
    public class RentalHistoryDto
    {
        public Guid RentalHistoryDtoId { get; set; }
        public RentalAssetDto RentalAssetDto { get; set; }
        public RentalClubCardDto RentalClubCardDto { get; set; }
        public DateTime CheckedOut { get; set; }
        public DateTime? CheckedIn { get; set; }
    }
}
