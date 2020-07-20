﻿using System;

namespace RentalPortal.Data.Models
{
    public class Status : EntityBase
    {
        public Guid StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
