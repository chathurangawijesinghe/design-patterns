public class ClassicSingleton
{
    private static ClassicSingleton? _instance;

    private ClassicSingleton() { }

    public static ClassicSingleton Instance
    {
        get
        {
            _instance ??= new ClassicSingleton();
            return _instance;
        }
    }
}