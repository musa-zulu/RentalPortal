using System;
using System.Collections.Generic;

namespace RentalPortal.Data.Models
{
    public class RentalClubCard : EntityBase
    {
        public Guid RentalClubCardId { get; set; }
        public decimal RentalFee { get; set; }
        public decimal OverDueFee { get; set; }
        public DateTime CardIssuedDate { get; set; }
        public virtual IEnumerable<Rental> Rentals { get; set; }
    }
}
