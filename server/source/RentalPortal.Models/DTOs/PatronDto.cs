using System;

namespace RentalPortal.Models.DTOs
{
    public class PatronDto
    {
        public Guid PatrolDtoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Guid AddressId { get; set; }
        public Guid TelephoneId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public RentalClubCardDto RentalClubCardDto { get; set; }
        public RentalBranchDto RentalBranchDto { get; set; }
    }
}
