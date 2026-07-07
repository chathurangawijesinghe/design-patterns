public class FourWheelerFactory : IVehicleFactory
{
    public Vehicle CreateVehicle()
    {
        return new FourWheeler();
    }
}