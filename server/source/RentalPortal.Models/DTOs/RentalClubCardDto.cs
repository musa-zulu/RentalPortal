using System;
using System.Collections.Generic;

namespace RentalPortal.Models.DTOs
{
    public class RentalClubCardDto
    {
        public Guid RentalClubCardId { get; set; }
        public decimal RentalFee { get; set; }
        public decimal OverDueFee { get; set; }
        public DateTime CardIssuedDate { get; set; }
        public virtual IEnumerable<RentalDto> RentalDto { get; set; }
    }
}
