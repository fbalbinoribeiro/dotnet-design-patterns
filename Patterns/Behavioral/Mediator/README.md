# Mediator Design Pattern

The **Mediator** pattern is a **behavioral** design pattern that centralizes communication between multiple objects (colleagues).  
Instead of objects referring to each other directly, they interact through a mediator, reducing dependencies and promoting loose coupling.

It involves two main participants:

- **Mediator**: defines the interface for communication between colleague objects.
- **Colleagues**: individual objects that communicate only through the mediator rather than with each other directly.

---

## Pros

- **Reduced coupling**: colleagues depend only on the mediator, not on each other.
- **Simplified communication**: complex many-to-many interactions are centralized.
- **Improved maintainability**: easier to extend or modify communication logic in one place.
- **Encapsulation of control logic**: mediator can coordinate workflows without exposing details to colleagues.

---

## Cons

- **Mediator complexity**: can grow into a “god object” if it centralizes too much logic.
- **Reduced reusability**: colleagues may become tied to a specific mediator implementation.
- **Indirect communication overhead**: adds a layer between objects, which can make debugging harder.
- **Single point of failure**: errors in the mediator can affect all interactions.

---

## Reference

[Refactoring.Guru — Mediator](https://refactoring.guru/design-patterns/mediator)
