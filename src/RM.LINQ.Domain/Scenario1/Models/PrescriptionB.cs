
namespace RM.LINQ.Domain.Scanario1.Models
{
    using System;
    using System.Collections.Generic;

    public class PrescriptionB
    {
        public DateTime DateTime { get; set; }
        public IEnumerable<DescriptionOfPrescriptionB> Descriptions { get; set; }
    }

    public class DescriptionOfPrescriptionB
    {
        public string Time { get; set; }
        public string Description { get; set; }
    }
}
