namespace CreationalDesignPatterns.Singleton.Xtra.Doubled_Checked;

public sealed class Singleton
{
    private static volatile Singleton instance = null!;
    private static readonly object syncRoot = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    instance ??= new Singleton();
                }
            }
            return instance;
        }
    }
}