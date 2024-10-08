# Singleton Design Pattern

The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.

## Use cases of Singleton pattern

- **Database Connections**: In applications where creating and managing database connections is an expensive operation, a Singleton can be used to maintain a single database connection throughout the application.
- **Configuration Management**: When you have global configuration settings that need to be accessed by various components of the application, a Singleton configuration manager can provide a single point of access to these settings.
- **GUI Components**: For graphical user interface (GUI) components or controllers, a Singleton can help manage the state and actions of the UI, providing a single point of control.
- **Device Managers**: In embedded systems or applications interacting with hardware devices, a Singleton can be used to manage and control access to hardware devices to avoid conflicts.
- **Printing Service**: In systems that involve printing documents or reports, a Singleton printing service can coordinate and manage print jobs, ensuring efficient use of printing resources.
- **Caching Mechanism**
  - Maintain a single cache instance accessible globally.
  - Share cached data across different parts of the application.
  - Manage cache invalidation centrally.
- **Thread Pool**:
  - Create a single thread pool instance
  - Reuse threads instead of constantly creating new ones
  - Limit the maximum number of threads
- **Dependency Injection Containers**: Dependency injection containers can be implemented as singletons to manage the lifecycle of objects and their dependencies.

## When to Avoid Singleton Design Pattern

- When you need to test your code, singletons can make it difficult to isolate and mock dependencies.
- When you need to create multiple instances of a class, singletons are not appropriate.
- When you need to follow the principle of least knowledge, singletons can violate this principle by making objects too tightly coupled.

## Alternatives to Singleton Design Pattern

- **Dependency Injection**: Dependency injection is a better alternative to singletons because it promotes loose coupling and testability.
- **Static Methods**: If you only need to call a few methods on a class, you can use static methods instead of a singleton.
- **Factory Method**: A factory method can be used to create instances of a class, but it doesn't guarantee that only one instance exists.

## Advantages of Singleton Design Pattern

- **Thread Safety**: Singleton ensures safe usage in multi-threaded applications, maintaining consistency and preventing race conditions.
- **Improved Performance**: Reusing the same instance eliminates the overhead of creating and destroying multiple instances, enhancing performance.
- **Simplified Configuration**: Singleton provides a centralized point for managing configuration settings, reducing redundancy.
- **Reduced Memory Usage**: By limiting instances to one, memory usage is optimized.

## Disadvantages of Singleton Design Pattern

- **Tight Coupling**: Overuse of Singleton can lead to tight coupling between classes, reducing flexibility and maintainability.
- **Testing Challenges**: Global state introduces challenges in unit testing due to potential side effects.
- **Violation of SRP**: Singleton classes can sometimes take on multiple responsibilities, violating the Single Responsibility Principle.
- **Concurrency Issues**: Synchronization mechanisms are required to handle concurrent access to the Singleton instance. If multiple threads attempt to create the Singleton simultaneously, it can result in [race conditions](https://en.wikipedia.org/wiki/Race_condition#Data_race).

## Code Samples

### With [Lazy](https://learn.microsoft.com/en-us/dotnet/api/system.lazy-1?view=net-8.0) in C# 

```csharp
using System;

public sealed class Singleton
{
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    private Singleton() { }

    public static Singleton Instance => instance.Value;
}
```

**Explanation**:

- `Lazy<Singleton>`: This class ensures that the instance is created only when it's first accessed, avoiding unnecessary initialization.
- Thread Safety: The `Lazy<Singleton>` class is inherently thread-safe, guaranteeing that only one instance is created even under concurrent access.
- Performance: The `Lazy<Singleton>` approach provides good performance, as the instance is created lazily and the thread safety mechanism is efficient.

### With Double-checked locking

```csharp
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
```

**Explanation**:

- `volatile` keyword: Ensures that the `instance` variable is read from memory and not from a cache, preventing stale values.
- `object syncRoot`: Provides a synchronization object for locking.
- Double-checked locking: Reduces the overhead of locking by checking the instance variable twice before entering the critical section.
- Thread safety: The code is thread-safe, ensuring that only one instance is created even under concurrent access.

## [Enum](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum) alternative

> You can use **enums** to simplify your Singleton implementation.
An **enumeration** type (or enum type) is a *value type* defined by a set of named constants of the underlying integral numeric type. To define an enumeration type, use the enum keyword and specify the names of enum members.

```csharp
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
```

## Useful Links

- [Double-checked locking](https://en.wikipedia.org/wiki/Double-checked_locking)
- [Connection pool](https://en.wikipedia.org/wiki/Connection_pool)