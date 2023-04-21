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
        var parkingLot = serviceProvider.GetRequiredService<IParkingLot>();
        var parkingReceipt = serviceProvider.GetRequiredService<IParkingReceipt>();
        try
        {
            DataFromFile dataFromFile = new DataFromFile();
            var jsonString = File.ReadAllText("TestFile.json");
            using (JsonDocument jsonDocument = JsonDocument.Parse(jsonString))
            {
                JsonElement root = jsonDocument.RootElement;
                dataFromFile.ParkingLot = root.GetProperty("ParkingLot").ToString();
                dataFromFile.Vehicle = root.GetProperty("Vehicle").ToString();
                dataFromFile.VehicleParkTime = root.GetProperty("ParkTime").ToString();
                dataFromFile.VehicleUnparkTime = root.GetProperty("UnparkTime").ToString();
                dataFromFile.Action = root.GetProperty("Action").ToString();
            }
            if (dataFromFile.Action == "Park")
            {
                switch (dataFromFile.ParkingLot.ToString())
                {
                    case "Airport":
                        Console.WriteLine(JsonSerializer.Serialize<ParkingTicket>(parkingLot.AirportParking(dataFromFile.Vehicle)));
                        break;
                    case "Stadium":
                        Console.WriteLine(JsonSerializer.Serialize<ParkingTicket>(parkingLot.StadiumParking(dataFromFile.Vehicle)));
                        break;
                    case "Mall":
                        Console.WriteLine(JsonSerializer.Serialize<ParkingTicket>(parkingLot.MallParking(dataFromFile.Vehicle)));
                        break;
                    default:
                        Console.WriteLine("Not able to park your vehicle now");
                        break;
                }
            }

            if (dataFromFile.Action == "Unpark")
            {
                switch (dataFromFile.ParkingLot.ToString())
                {
                    case "Airport":
                        Console.WriteLine(JsonSerializer.Serialize<ParkingLotApp.Models.ParkingReceipt>(parkingReceipt.AirportParking(dataFromFile.VehicleParkTime, dataFromFile.VehicleUnparkTime, dataFromFile.Vehicle)));
                        break;
                    case "Stadium":
                        Console.WriteLine(JsonSerializer.Serialize<ParkingLotApp.Models.ParkingReceipt>(parkingReceipt.StadiumParking(dataFromFile.VehicleParkTime, dataFromFile.VehicleUnparkTime, dataFromFile.Vehicle)));
                        break;
                    case "Mall":
                        Console.WriteLine(JsonSerializer.Serialize<ParkingLotApp.Models.ParkingReceipt>(parkingReceipt.MallParking(dataFromFile.VehicleParkTime, dataFromFile.VehicleUnparkTime, dataFromFile.Vehicle)));
                        break;
                    default:
                        Console.WriteLine("Not able to unpark your vehicle now");
                        break;
                }
            }

            //string jsonString = JsonSerializer.Serialize<ParkingTicket>(parkingLot.AirportParking("Cars_SUV"));

            //string jsonString = JsonSerializer.Serialize<ParkingLotApp.Models.ParkingReceipt>(parkingReceipt.AirportParking("2016-12-01T00:00:00", "2016-12-31T23:59:59", "Cars_SUV"));
            //Console.WriteLine(jsonString);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

}