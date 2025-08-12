# Template Method Design Pattern

The **Template Method** pattern is a **behavioral** design pattern that defines the skeleton of an algorithm in a base class but lets subclasses override specific steps without changing the overall algorithm’s structure.

---

## Pros

- **Code reuse**: common algorithm structure lives in the base class, avoiding duplication.
- **Consistency**: ensures all subclasses follow the same sequence of steps.
- **Open/Closed Principle**: behavior can be extended by overriding specific steps without modifying the template itself.
- **Simplifies maintenance**: changes to the algorithm’s structure happen in one place.

---

## Cons

- **Inheritance coupling**: relies on subclassing, which can limit flexibility compared to composition-based approaches.
- **Difficult to modify sequence**: changing the algorithm flow requires altering the base class.
- **Potential for too many hooks**: overuse can lead to complex and hard-to-follow hierarchies.

---

## Reference

[Refactoring.Guru — Template Method](https://refactoring.guru/design-patterns/template-method)
