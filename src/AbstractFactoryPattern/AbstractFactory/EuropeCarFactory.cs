public class EuropeCarFactory : CarFactory
{
    public Car CreateCar()
    {
        return new Hatchback();
    }

    public CarSpecification CreateSpecification()
    {
        return new EuropeSpecification();
    }
}