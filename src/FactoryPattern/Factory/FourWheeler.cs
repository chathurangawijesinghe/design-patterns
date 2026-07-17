public class FourWheeler : IVehicle
{
    public Task PrintVehicle()
    {
        Console.WriteLine("This is a Four Wheeler");
        return Task.CompletedTask;
    }
}