public class EuropeCarFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Hatchback();
    }

    public ICarSpecification CreateSpecification()
    {
        return new EuropeSpecification();
    }
}