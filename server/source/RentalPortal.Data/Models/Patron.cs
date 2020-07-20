using System;

namespace RentalPortal.Data.Models
{
    public class Patron : EntityBase
    {
        public Guid PatronId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid AddressId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid TelephoneId { get; set; }
        public string Gender { get; set; }
        public RentalClubCard RentalClubCard { get; set; }
        public RentalBranch HomeRentalBranch { get; set; }
    }
}
