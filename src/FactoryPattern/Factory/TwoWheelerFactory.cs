public class TwoWheelerFactory : IVehicleFactory
{
    public Vehicle CreateVehicle()
    {
        return new TwoWheeler();
    }
}