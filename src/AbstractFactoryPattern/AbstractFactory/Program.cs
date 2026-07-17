
// creating car for north america
ICarFactory northAmericaFactory = new NorthAmericaCarFactory();
ICar northAmericaCar = northAmericaFactory.CreateCar();
ICarSpecification northAmericaSpecification = northAmericaFactory.CreateSpecification();

northAmericaCar.Assemble();
northAmericaSpecification.Display();

// creating car for europe
ICarFactory europeFactory = new EuropeCarFactory();
ICar europeCar = europeFactory.CreateCar();
ICarSpecification europeSpecification = europeFactory.CreateSpecification();

europeCar.Assemble();
europeSpecification.Display();

Console.WriteLine("Hello, World!");
