using Xunit;
using Ovning5_Garage.Services;
using Ovning5_Garage.Models;


namespace GarageTest
{
    public class GarageTest
    {
        [Fact]
        public void Constructor_InitializesCorrectly()
        {
            //-- Arrange
            int expectedCapacity = 25;
            
            //-- Act
            Garage<Vehicle> garage = new Garage<Vehicle>(expectedCapacity);

            //-- Assert
            Assert.Equal(expectedCapacity, garage.Capacity);
            Assert.Empty(garage);

        }

        //[Fact]
        //public void AddVehicle_ShouldReturnTrue_WhenGarageIsNotFull()
        //{
        //    // Arrange

        //    // Act

        //    // Assert
        //}


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