public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton instance;
    private static readonly object lockObject = new object();

    private ThreadSafeSingleton() { }

    public static ThreadSafeSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }
            return instance;
        }
    }
}