using System;

namespace RentalPortal.Data.Models
{
    public class AssetType : EntityBase
    {
        public Guid AssetTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
