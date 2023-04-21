using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using ParkingLotApp.Interfaces;
using ParkingLotApp.Models;
using ParkingLotApp.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IVehicleParking, VehicleParking>()
            .AddSingleton<IParkingLot, ParkingLot>()
            .AddSingleton<IParkingLotFees, ParkingLotFees>()
            .AddSingleton<IParkingReceipt, ParkingLotApp.Services.ParkingReceipt>()
            .BuildServiceProvider();


        var vehicleParking = serviceProvider.GetRequiredService<IVehicleParking>();
        //var parkingLot = serviceProvider.GetRequiredService<IParkingLot>();
        //string jsonString = JsonSerializer.Serialize<ParkingTicket>(parkingLot.AirportParking("Cars_SUV"));
        var parkingReceipt = serviceProvider.GetRequiredService<IParkingReceipt>();
        string jsonString = JsonSerializer.Serialize<ParkingLotApp.Models.ParkingReceipt>(parkingReceipt.AirportParking("2016-12-01T00:00:00", "2016-12-31T23:59:59", "Cars_SUV"));

        Console.WriteLine(jsonString);
    }

}