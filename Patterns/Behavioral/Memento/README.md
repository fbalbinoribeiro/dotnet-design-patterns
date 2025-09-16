# Memento Design Pattern

The **Memento** pattern is a **behavioral** design pattern that provides the ability to capture and externalize an object’s internal state without violating encapsulation.  
This allows the object to be restored to that state later.

It involves three main participants:

- **Originator**: the object whose state needs to be saved and restored.
- **Memento**: the object that stores the state snapshot.
- **Caretaker**: manages the saved mementos but does not modify their contents.

---

## Pros

- **Encapsulation preserved**: internal state is stored without exposing implementation details.
- **Undo/redo functionality**: enables straightforward implementation of history mechanisms.
- **State rollback**: allows restoring a previous state after invalid operations or errors.
- **Separation of concerns**: originator only creates/restores mementos, caretaker handles lifecycle.

---

## Cons

- **Memory overhead**: frequent or large snapshots may consume significant memory.
- **Performance impact**: capturing deep object states can be computationally expensive.
- **Complex storage**: managing multiple mementos (e.g., undo stacks) adds complexity.
- **Partial restore limitations**: restoring only part of the state without breaking encapsulation can be tricky.

---

## Reference

[Refactoring.Guru — Memento](https://refactoring.guru/design-patterns/memento)
