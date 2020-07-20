using System;

namespace RentalPortal.Data.Models
{
    public class RentalAsset : EntityBase
    {
        public Guid RentalAssetId { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Status Status { get; set; }
        public decimal ReplacementCost { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfItems { get; set; }
        public virtual RentalBranch RentalBranch { get; set; }
    }
}
