# Observer Design Pattern

The **Observer** pattern is a **behavioral** design pattern that defines a one-to-many dependency between objects. When one object (the _subject_) changes state, all its dependents (_observers_) are automatically notified and updated.

---

## Pros

- **Loose coupling**: subjects and observers interact through an abstract interface, reducing dependencies.
- **Scalability**: multiple observers can subscribe to the same subject without the subject knowing details about them.
- **Dynamic subscription**: observers can subscribe or unsubscribe at runtime, providing flexibility.
- **Promotes reusability**: observers can be reused across different subjects.

---

## Cons

- **Unexpected updates**: observers may receive frequent or unnecessary notifications, leading to performance issues.
- **Order of notification**: if many observers are subscribed, the update order may affect the system’s behavior and is often hard to control.
- **Memory leaks**: if observers are not properly unsubscribed, they can stay in memory longer than intended.
- **Complex debugging**: tracing the flow of state changes across many observers can be difficult.

---

## Reference

[Refactoring.Guru — Observer](https://refactoring.guru/design-patterns/observer)
