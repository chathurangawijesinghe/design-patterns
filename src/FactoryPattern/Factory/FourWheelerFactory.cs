public class FourWheelerFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new FourWheeler();
    }
}