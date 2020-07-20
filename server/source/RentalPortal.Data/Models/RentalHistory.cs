using System;

namespace RentalPortal.Data.Models
{
    public class RentalHistory : EntityBase
    {
        public Guid RentalHistoryId { get; set; }
        public DateTime CheckedOut { get; set; }
        public DateTime? CheckedIn { get; set; }
        public RentalAsset RentalAsset { get; set; }       
        public RentalClubCard RentalClubCard { get; set; }
    }
}
