# dotnet-design-patterns

A collection of examples demonstrating common **design patterns** implemented in **.NET** (C#).  
This repository serves as a reference and learning resource for developers looking to understand, apply, and experiment with various design patterns in a practical way.

---

## About

Each design pattern is implemented in its own folder with:

- A **README.md** explaining the pattern, its usage, pros and cons.
- Example **C# code** showing how to implement the pattern.

---

## How to Use

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/dotnet-design-patterns.git
   ```

2. Enjoy

---

## Design Patterns Index

| Pattern Name            | Type       | Link                                                            | Brief Explanation                                                                                        | Similar Patterns                  |
| ----------------------- | ---------- | --------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | --------------------------------- |
| Strategy                | Behavioral | [README](./Patterns/Behavioral/Strategy/README.md)              | Defines a family of algorithms, encapsulates each one, and makes them interchangeable.                   | State, Template Method            |
| Template Method         | Behavioral | [README](./Patterns/Behavioral/TemplateMethod/README.md)        | Defines the skeleton of an algorithm, allowing subclasses to override specific steps.                    | Strategy, Factory Method          |
| Command                 | Behavioral | [README](./Patterns/Behavioral/Command/README.md)               | Encapsulates a request as an object, allowing parameterization and queuing of requests.                  | Mediator, Chain of Responsibility |
| Iterator                | Behavioral | [README](./Patterns/Behavioral/Iterator/README.md)              | Provides a way to access elements of a collection sequentially without exposing its representation.      | Composite, Factory Method         |
| State                   | Behavioral | [README](./Patterns/Behavioral/State/README.md)                 | Allows an object to alter its behavior when its internal state changes, appearing as if it changed.      | Strategy, Interpreter             |
| Observer                | Behavioral | [README](./Patterns/Behavioral/Observer/README.md)              | Defines a one-to-many dependency so that when one object changes state, all its dependents are notified. | Mediator, Event Bus               |
| Memento                 | Behavioral | [README](./Patterns/Behavioral/Memento/README.md)               | Captures and externalizes an object’s internal state without exposing details, allowing restoration.     | Command, Prototype                |
| Chain of Responsibility | Behavioral | [README](./Patterns/Behavioral/ChainOfResponsibility/README.md) | Passes requests along a chain of handlers, each deciding to process or forward the request further.      | Command, Decorator                |
| Mediator                | Behavioral | [README](./Patterns/Behavioral/Mediator/README.md)              | Centralizes communication between objects, reducing dependencies and simplifying interactions.           | Observer, Command                 |
| Visitor                 | Behavioral | [README](./Patterns/Behavioral/Visitor/README.md)               | Lets you define new operations on object structures without modifying their classes.                     | Iterator, Composite               |