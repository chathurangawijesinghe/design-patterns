public class TwoWheeler : IVehicle
{
    public Task PrintVehicle()
    {
        Console.WriteLine("This is a Two Wheeler");
        return Task.CompletedTask;
    }
}