public sealed class ThreadSafeSingletonStaticInitializationApproach
{
    private static readonly ThreadSafeSingletonStaticInitializationApproach instance = new ThreadSafeSingletonStaticInitializationApproach();

    static ThreadSafeSingletonStaticInitializationApproach() { }

    private ThreadSafeSingletonStaticInitializationApproach() { }

    public static ThreadSafeSingletonStaticInitializationApproach Instance => instance;
}