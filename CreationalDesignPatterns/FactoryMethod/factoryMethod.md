# Factory Method Design Pattern

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,
but allows subclasses to alter the type of objects that will be created.

## Applicability

- Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
- When you want to decouple the object creation process from the code that uses the objects.
- When you need to create families of related objects.
- When you want to encapsulate object creation logic within a specific class or set of classes.
- Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.
- Use the Factory Method when you want to provide users of your library or framework with a way to extend its internal components.(use inheritance and override methods.)

> Let’s think about what has to be done to reuse an existing object:

1. First, you need to create some storage to keep track of all of the created objects.
2. When someone requests an object, the program should look for a free object inside that pool.
3. and then return it to the client code.
4. If there are no free objects, the program should create a new one (and add it to the pool).

That’s a lot of code! And it must all be put into a single place so that you don’t pollute the program with duplicate code.
Probably the most obvious and convenient place where this code could be placed is the constructor of the class whose objects we’re trying to reuse. However, a constructor must always return new objects by definition. It can’t return existing instances.
Therefore, you need to have a regular method capable of creating new objects as well as reusing existing ones. That sounds very much like a factory method.

## Pros

- You avoid tight coupling between the creator and the concrete products.
- Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
- Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.

## Cons

- The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.

> Factory Method is a specialization of **Template Method**. At the same time, a Factory Method may serve as a step in a large Template Method.
