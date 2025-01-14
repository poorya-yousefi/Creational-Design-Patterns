# Abstract Factory Design Pattern

Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

## Applicability

> Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.

* The Abstract Factory provides you with an interface for creating objects from each class of the product family. As long as your code creates objects via this interface, you don’t have to worry about creating the wrong variant of a product which doesn’t match the products already created by your app.
* Consider implementing the Abstract Factory when you have a class with a set of Factory Methods that blur its primary responsibility.
* In a well-designed program each class is responsible only for one thing. When a class deals with multiple product types, it may be worth extracting its factory methods into a stand-alone factory class or a full-blown Abstract Factory implementation.

## Pros

* You can be sure that the products you’re getting from a factory are compatible with each other.
* You avoid tight coupling between concrete products and client code.
* Single Responsibility Principle. You can extract the product creation code into one place, making the code easier to support.
* Open/Closed Principle. You can introduce new variants of products without breaking existing client code.

## Cons

* The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.

## Relations with Other Patterns

1. Many designs start by using `Factory Method` (less complicated and more customizable via subclasses) and evolve toward `Abstract Factory`, `Prototype`, or `Builder` (more flexible, but more complicated).
2. `Builder` focuses on constructing complex objects step by step. `Abstract Factory` specializes in creating families of related objects. `Abstract Factory` returns the product immediately, whereas `Builder` lets you run some additional construction steps before fetching the product.
3. `Abstract Factory` classes are often based on a set of Factory Methods, but you can also use _Prototype_ to compose the methods on these classes.
4. `Abstract Factory` can serve as an alternative to Facade when you only want to *hide* the way the subsystem objects are created from the client code.
5. You can use `Abstract Factory` along with `Bridge`. This pairing is useful when some abstractions defined by `Bridge` can only work with specific implementations. In this case, `Abstract Factory` can encapsulate these relations and hide the complexity from the client code.
6. Abstract Factories, Builders and Prototypes can all be implemented as **Singletons**.

## Usage in real world apps

* **GUI libraries**: `Qt`, `GTK`, `MFC` and others have abstract factories for buttons, windows, dialogs and other interface elements.
* **Databases**: `ORM` libraries can have a set of factories for different database backends.
* **Unit testing**: You can use a factory to create mock objects for testing, and then swap them out with real objects in the production code.
* **Logging**: You can use the abstract factory to switch between different logging strategies.