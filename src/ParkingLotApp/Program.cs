﻿public class Program
{
    private readonly IClientDataService service;

    public Program(IClientDataService service) {
        this.service = service;
    }

    public void SomeMethod() {
        //...
    }

    public static void Main(string[] args) {
        IServiceProvider serviceProvider = RegisterServices();

        Program program = serviceProvider.GetService<Program>();

        program.SomeMethod();

        DisposeServices(serviceProvider);
    }
    

    private static IServiceProvider RegisterServices() {
        var services = new ServiceCollection();

        //repositories
        services.AddScoped<IAccountDataRepository, AccountDataRepository>();
        services.AddScoped<IClientDataRepository, ClientDataRepository>();
        services.AddScoped<IAddressDataRepository, AddressDataRepository>();
        services.AddScoped<IClientAccountDataRepository, ClientAccountDataRepository>();
        //services
        services.AddScoped<IAccountDataService, AccountDataService>();
        services.AddScoped<IClientDataService, ClientDataService>();
        services.AddScoped<IAddressDataService, AddressDataService>();
        services.AddScoped<IClientAccountDataService, ClientAccountDataService>();
        services.AddLogging(); //<-- LOGGING
        //main
        services.AddScoped<Program>(); //<-- NOTE THIS

        return services.BuildServiceProvider();
    }
    private static void DisposeServices(IServiceProvider serviceProvider) {
        if (serviceProvider == null) {
            return;
        }
        if (serviceProvider is IDisposable sp) {
            sp.Dispose();
        }
    }
}