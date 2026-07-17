public class TwoWheelerFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new TwoWheeler();
    }
}