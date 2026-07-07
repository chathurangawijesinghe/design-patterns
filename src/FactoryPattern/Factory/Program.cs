IVehicleFactory vehicleFactory = new TwoWheelerFactory();
Vehicle vehicle = vehicleFactory.CreateVehicle();
await vehicle.PrintVehicle();

vehicleFactory = new FourWheelerFactory();
vehicle = vehicleFactory.CreateVehicle();
await vehicle.PrintVehicle();

Console.WriteLine("Hello, World!");
