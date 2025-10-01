# Visitor Design Pattern

The **Visitor** pattern is a **behavioral** design pattern that allows adding new operations to existing object structures without modifying their classes.  
It separates an algorithm from the object structure it operates on, promoting open/closed principle compliance.

It involves two main participants:

- **Visitor**: defines operations to be performed on elements of the object structure.
- **Elements**: objects in the structure that accept a visitor and delegate the operation to it.

---

## Pros

- **Open/Closed Principle**: new operations can be added without modifying existing element classes.
- **Separation of concerns**: keeps algorithms separate from the objects they operate on.
- **Easier extension**: different behaviors can be implemented by creating new visitors.
- **Centralized operations**: related operations are grouped in one place (visitor classes).

---

## Cons

- **Element changes are costly**: adding a new element type requires updating all visitors.
- **Double dispatch complexity**: relies on both element and visitor to determine the operation, which can make it harder to follow.
- **Tight coupling between visitors and elements**: visitors must know the full set of element types.
- **Reduced flexibility**: frequent structural changes in elements make the pattern less effective.

---

## Reference

[Refactoring.Guru — Visitor](https://refactoring.guru/design-patterns/visitor)
