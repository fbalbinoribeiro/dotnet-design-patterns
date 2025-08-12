# Strategy Design Pattern

The **Strategy** pattern is a **behavioral** design pattern that lets you define a family of algorithms, encapsulate each one, and make them interchangeable. It allows the algorithm to vary independently from the clients that use it.

---

## Pros

- **Eliminates complex conditionals** by delegating algorithm choice to interchangeable objects.
- **Open/Closed Principle**: add new strategies without changing existing client code.
- **Improved testability**: each strategy can be unit tested in isolation.
- **Runtime flexibility**: easily switch strategies without modifying the context.

---

## Cons

- **Increased number of classes**: each algorithm requires its own implementation.
- **Client awareness**: clients or factories must know which strategy to use.
- **Overhead in simple cases**: may be unnecessary if there's only one fixed algorithm.

---

## Reference

[Refactoring.Guru — Strategy](https://refactoring.guru/design-patterns/strategy)
