public class ThreadSafeSingletonModernApproach
{
    private static readonly Lazy<ThreadSafeSingletonModernApproach> instance = new Lazy<ThreadSafeSingletonModernApproach>(() => new ThreadSafeSingletonModernApproach());

    private ThreadSafeSingletonModernApproach() { }

    public static ThreadSafeSingletonModernApproach Instance => instance.Value;
}