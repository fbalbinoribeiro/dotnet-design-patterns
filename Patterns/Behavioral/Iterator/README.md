# Iterator Design Pattern

The **Iterator** pattern is a **behavioral** design pattern that provides a way to access elements of a collection sequentially without exposing its underlying representation (e.g., array, list, tree).

---

## Pros

- **Separation of concerns**: iteration logic is kept separate from the collection itself.
- **Uniform access**: provides a standard way to traverse different types of collections.
- **Multiple traversals**: allows several iterators to traverse the same collection independently.
- **Open/Closed Principle**: new iteration strategies can be introduced without modifying the collection.

---

## Cons

- **Increased complexity**: adds extra classes (iterators) even for simple collections.
- **Overhead for small collections**: may be unnecessary when built-in iteration mechanisms already exist.
- **Concurrent modifications**: can complicate iteration if the collection is modified while being traversed.

---

## Reference

[Refactoring.Guru — Iterator](https://refactoring.guru/design-patterns/iterator)
