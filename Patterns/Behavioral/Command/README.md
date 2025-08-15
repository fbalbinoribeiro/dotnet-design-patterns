# Command Design Pattern

The **Command** pattern is a **behavioral** design pattern that encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

---

## Pros

- **Encapsulation of requests**: separates the object that invokes the operation from the one that knows how to perform it.
- **Easier undo/redo implementation**: store and replay commands as needed.
- **Supports queuing and scheduling**: commands can be stored and executed later.
- **Promotes open/closed principle**: new commands can be added without changing existing code.

---

## Cons

- **Increased number of classes**: each command requires its own class.
- **Potential overengineering**: may be too complex for simple actions.
- **Extra indirection**: understanding flow may be harder due to separation of invoker and receiver.

---

## Reference

[Refactoring.Guru — Command](https://refactoring.guru/design-patterns/command)
