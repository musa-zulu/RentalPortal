using System;

namespace RentalPortal.Models.DTOs
{
    public class AssetTypeDto
    {
        public Guid AssetTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
