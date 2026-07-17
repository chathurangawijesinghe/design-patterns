
// creating car for north america
CarFactory northAmericaFactory = new NorthAmericaCarFactory();
Car northAmericaCar = northAmericaFactory.CreateCar();
CarSpecification northAmericaSpecification = northAmericaFactory.CreateSpecification();

northAmericaCar.Assemble();
northAmericaSpecification.Display();

// creating car for europe
CarFactory europeFactory = new EuropeCarFactory();
Car europeCar = europeFactory.CreateCar();
CarSpecification europeSpecification = europeFactory.CreateSpecification();

europeCar.Assemble();
europeSpecification.Display();

Console.WriteLine("Hello, World!");
