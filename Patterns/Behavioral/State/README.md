# State Design Pattern

The **State** pattern is a **behavioral** design pattern that allows an object to alter its behavior when its internal state changes. It encapsulates state-specific logic into separate classes, making the object’s behavior easier to manage and extend.

---

## Pros

- **Simplifies conditional logic**: replaces complex `if/else` or `switch` statements with polymorphism.
- **Encapsulation**: state-specific code is isolated inside dedicated classes.
- **Open/Closed Principle**: adding new states does not require changing the main context class.
- **Improved readability**: makes the flow of state transitions explicit and easier to follow.

---

## Cons

- **Increased number of classes**: may lead to class explosion if there are many states.
- **State transition complexity**: requires careful handling of transitions between states.
- **Overhead for simple scenarios**: can be overkill if the logic could be managed with a small conditional.

---

## Reference

[Refactoring.Guru — State](https://refactoring.guru/design-patterns/state)
