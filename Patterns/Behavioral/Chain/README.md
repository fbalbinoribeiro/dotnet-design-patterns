# Chain of Responsibility Design Pattern

The **Chain of Responsibility** pattern is a **behavioral** design pattern that lets you pass requests along a chain of handlers. Each handler decides either to process the request or to pass it to the next handler in the chain, decoupling senders from receivers and enabling flexible responsibility assignment.

---

## Pros

- **Loose coupling**: senders don’t need to know which handler will process the request.
- **Open/closed flexibility**: add, remove, or reorder handlers without changing client code.
- **Single-responsibility**: each handler focuses on one concern (e.g., auth, validation, logging).
- **Graceful fallbacks**: if one handler can’t process, the request can continue down the chain.

---

## Cons

- **Uncertain handling**: a request might go unhandled if the chain lacks a suitable handler.
- **Harder debugging**: tracing the request path across many handlers can be tricky.
- **Potential performance cost**: requests may traverse multiple handlers unnecessarily.
- **Hidden dependencies**: excessive chaining can obscure system behavior and responsibilities.

---

## Reference

[Refactoring.Guru — Chain of Responsibility](https://refactoring.guru/design-patterns/chain-of-responsibility)
