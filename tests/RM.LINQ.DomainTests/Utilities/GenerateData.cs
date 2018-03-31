
namespace RM.LINQ.DomainTests.Utilities
{
    using Bogus;
    using Domain.Scanario1.Models;
    using System;
    using System.Collections.Generic;

    public class GenerateData
    {
        public static List<PrescriptionA> ListPrescriptionA(int quantity = 50)
        {
            return new Faker<PrescriptionA>("pt_BR")
                .CustomInstantiator(f =>
                {
                    return new PrescriptionA()
                    {
                        DateTime = f.Date.Between(DateTime.Now.AddDays(-10), DateTime.Now),
                        Description = f.Lorem.Text()
                    };
                })
                .Generate(quantity);                 
        }
    }
}
