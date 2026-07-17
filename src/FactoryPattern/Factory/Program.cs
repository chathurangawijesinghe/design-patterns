IVehicleFactory vehicleFactory = new TwoWheelerFactory();
IVehicle vehicle = vehicleFactory.CreateVehicle();
await vehicle.PrintVehicle();

vehicleFactory = new FourWheelerFactory();
vehicle = vehicleFactory.CreateVehicle();
await vehicle.PrintVehicle();

Console.WriteLine("Hello, World!");
