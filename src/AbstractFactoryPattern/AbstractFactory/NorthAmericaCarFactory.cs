public class NorthAmericaCarFactory : CarFactory
{
    public Car CreateCar()
    {
        return new Sedan();
    }

    public CarSpecification CreateSpecification()
    {
        return new NorthAmericaSpecification();
    }
}