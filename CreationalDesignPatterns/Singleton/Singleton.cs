namespace CreationalDesignPatterns.Singleton;

public class Singleton
{
    private static Singleton _instance = null!;

    private Singleton() { }

    // best for single thread 
    public static Singleton GetInstance()
    {
        return _instance ??= new Singleton();
    }

}