public sealed class ThreadSafeSingletonClassicApproach
{
    private static ThreadSafeSingletonClassicApproach instance;
    private static readonly object lockObject = new object();

    private ThreadSafeSingletonClassicApproach() { }

    public static ThreadSafeSingletonClassicApproach Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingletonClassicApproach();
                    }
                }
            }
            return instance;
        }
    }
}