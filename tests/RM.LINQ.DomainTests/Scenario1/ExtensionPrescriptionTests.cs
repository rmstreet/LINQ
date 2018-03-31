using FluentAssertions;
using RM.LINQ.Domain.Scanario1.Models;
using RM.LINQ.Domain.Scenario1;
using RM.LINQ.DomainTests.Utilities;
using System;
using Xunit;

namespace RM.LINQ.DomainTests
{
    public class ExtensionPrescriptionTests
    {
        [Fact]
        public void ConvertListOfPrescritionAToListOfPrescriptionB()
        {
            // Arrange
            var listOfPrescriptionA = GenerateData.ListPrescriptionA();

            // Act
            var listOfPrescriptionB = listOfPrescriptionA.ConverteToListOfPrescriptionB();

            // Assert
            listOfPrescriptionB.Should()
                .NotBeEmpty()
                .And
                .ContainInOrder()
                .And
                .ContainItemsAssignableTo<PrescriptionB>();
            

        }
    }
}
