using System;

namespace RentalPortal.Models.DTOs
{
    public class RentalAssetDto
    {
        public Guid RentalAssetDtoId { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public StatusDto Status { get; set; }
        public decimal ReplacementCost { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfItems { get; set; }
        public virtual RentalBranchDto RentalBranchDto { get; set; }
    }
}
