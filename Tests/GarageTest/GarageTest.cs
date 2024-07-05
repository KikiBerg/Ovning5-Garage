using Xunit;
using Ovning5_Garage.Services;
using Ovning5_Garage.Models;
using System;
using System.Collections.Generic;



namespace GarageTest
{

    public class Vehicle
    {
        public string? RegistrationNumber { get; set; }
    }

    public class Car : Vehicle { }


    public class GarageTest
    {

        private Garage<Car> garage;

        [Fact]
        public void Constructor_InitializesCorrectly()
        {
            //-- Arrange
            int expectedCapacity = 25;

            //-- Act
            Garage<Vehicle> garage = new(expectedCapacity);

            //-- Assert
            Assert.Equal(expectedCapacity, garage.GetCapacity());
            Assert.Empty(garage);

        }

        [Fact]
        public void AddVehicle_ShouldReturnTrue_WhenGarageIsNotFull()
        {
            // Arrange
            var car = new Car { RegistrationNumber = "XYZ123" };

            // Act
            bool result = garage.AddVehicle(car);

            // Assert
            Assert.True(result);
            Assert.Equal(1, garage.GetCount());
        }


        //[Fact]
        //public void AddVehicle_ShouldReturnFalse_WhenGarageIsFull()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}


        //[Fact]
        //public void RemoveVehicle_ShouldReturnTrue_WhenVehicleIsFound()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}


        //[Fact]
        //public void RemoveVehicle_ShouldReturnFalse_WhenVehicleIsNotFound()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}



        //[Fact]
        //public void FindVehicle_ShouldFindVehicleSuccessfully()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}

        //[Fact]
        //public void FindVehicle_ShouldReturnNull_WhenVehicleDoesNotExist()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}

        //[Fact]
        //public void GetCapacity_ReturnsCorrectCapacity()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}






        //[Fact]
        //public void GetCount_ReturnsCorrectCount()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}

    }
}