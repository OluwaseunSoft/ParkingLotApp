using ParkingLotApp.Models;

namespace ParkingLotApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var testVehicles = new Vehicles
        {
           Motorcycles = "89"
        };

        //Act
        testVehicles.Motorcycles = "Test Pipeline";

        //Assert
        Assert.Equal("Test Pipeline", testVehicles.Motorcycles);
    }
}