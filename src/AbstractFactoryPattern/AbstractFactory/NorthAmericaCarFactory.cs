public class NorthAmericaCarFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Sedan();
    }

    public ICarSpecification CreateSpecification()
    {
        return new NorthAmericaSpecification();
    }
}