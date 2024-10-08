# Builder Design Pattern

Builder is a creational design pattern that lets you construct complex objects *step by step*. The pattern allows you to produce different types and representations of an object using the same construction code.

## How to implement

1. Make sure that you can clearly define the common construction steps for building all available product representations. Otherwise, you won’t be able to proceed with implementing the pattern.

1. Declare these steps in the base builder interface.

1. Create a concrete builder class for each of the product representations and implement their construction steps.

1. Think about creating a director class. It may encapsulate various ways to construct a product using the same builder object.

1. The client code creates both the builder and the director objects. Before construction starts, the client must pass a builder object to the director. Usually, the client does this only once, via parameters of the director’s class constructor. The director uses the builder object in all further construction. There’s an alternative approach, where the builder is passed to a specific product construction method of the director.

1. The construction result can be obtained directly from the director only if all products follow the same interface. Otherwise, the client should fetch the result from the builder.

## Pros

- You can construct objects step-by-step, defer construction steps or run steps recursively.
- You can reuse the same construction code when building various representations of products.
- Single Responsibility Principle. You can isolate complex construction code from the business logic of the product.

## Cons

- The overall complexity of the code increases since the pattern requires creating multiple new classes.
- You may need to write more [boilerplate code](https://en.wikipedia.org/wiki/Boilerplate_code) to implement the builder pattern, which can increase the overall codebase size.

## Relations with other patterns

- Many designs start by using Factory Method (less complicated and more customizable via subclasses) and evolve toward Abstract Factory, Prototype, or Builder (more flexible, but more complicated).

- Builder focuses on constructing complex objects step by step. Abstract Factory specializes in creating families of related objects. Abstract Factory returns the product *immediately*, whereas Builder lets you run some additional construction steps before fetching the product.

- You can use Builder when creating complex Composite *trees* because you can program its construction steps to work *recursively*.

- You can combine Builder with *Bridge*: the director class plays the role of the abstraction, while different builders act as implementations.

- Abstract Factories, Builders and Prototypes can all be implemented as Singletons.

## Useful Links

[Builder Design Pattern](https://refactoring.guru/design-patterns/builder)
