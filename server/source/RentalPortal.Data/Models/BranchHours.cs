using System;

namespace RentalPortal.Data.Models
{
    public class BranchHours : EntityBase
    {
        public Guid BranchHoursId { get; set; }
        public RentalBranch Branch { get; set; }
        public int DayOfWeek { get; set; }
        public int OpeningTime { get; set; }
        public int ClosingTime { get; set; }
    }
}
