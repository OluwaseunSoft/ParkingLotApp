using ParkingLotApp.Models;

namespace ParkingLotApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var testData = new DataFromFile
        {
           ParkingLot = "Airport"
        };

        //Act
        testData.ParkingLot = "Airport";

        //Assert
        Assert.Equal("Stadium", testData.ParkingLot);
    }
}