using RM.LINQ.Domain.Scanario1.Models;

namespace RM.LINQ.Domain.Scenario1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionPrescription
    {
        public static IEnumerable<PrescriptionB> ConverteToListOfPrescriptionB(this List<PrescriptionA> listOfPrescriptionA)
        {
            return listOfPrescriptionA
                .GroupBy(p => p.DateTime.ToShortDateString(), 
                         p =>
                            {
                                var dynamicObj = new { Description = p.Description,
                                                       Time = p.DateTime.ToShortTimeString()
                                                     };
                                return dynamicObj;
                            }
                        )
                .Select(p =>
                            {
                                var prescB = new PrescriptionB();

                                prescB.DateTime = DateTime.Parse(p.Key);
                                prescB.Descriptions = p.Select(d => new DescriptionOfPrescriptionB { Description = d.Description, Time = d.Time }).OrderBy(o => o.Time);
                                return prescB;
                            }
                       );
                        
        }
    }
}
