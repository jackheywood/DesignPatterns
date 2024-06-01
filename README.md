# C# Design Patterns

## Creational Patterns

- Deal with the creation (_construction_) of objects
- Explicit (_constructor_) vs. implicit (_DI, reflection, etc._)
- Wholesale (_single statement_) vs. piecewise (_step-by-step_)

### Builder

#### Motivation

- Some objects are simple and can be created in a single constructor call,
  other objects require a lot of ceremony to create
- Having an object with 10 constructor arguments is not productive,
  opt for **piecewise** construction instead
- **Builder** provides an API for constructing an object step-by-step

#### Summary

- A **builder** is a separate component for building an object
- Can either give builder a constructor or return it via a static function
- To make builder fluent, return `this`
- Different facets of an object can be built with different builders working
  in tandem via a base class

### Factory

#### Motivation

- Object creation logic becomes too convoluted
- Constructor is not descriptive
  - Name mandated by name of containing type
  - Cannot overload with the same set of arguments with different names
  - Can turn into "optional parameter hell"
- **Wholesale** object creation can be outsourced to:
  - A separate function (**Factory Method**)
  - A separate class (**Factory**)
- Can create hierarchy of factories with **Abstract Factory** 

#### Summary

- A **factory** is a component responsible solely for the wholesale
  (not piecewise) creation of objects
- A factory method is a static method that creates objects
- A factory class can take care of object creation
- A factory can be external or reside inside the object as an inner class
- Hierarchies of factories can be used to create related objects

### Prototype

#### Motivation

- Complicated objects (_e.g. cars_) aren't designed from scratch
- An existing (_partially or fully constructed_) design is a **prototype**
- We make a copy (_clone_) of the prototype and customise it
  - Requires 'deep copy' support
- We make the cloning convenient (_e.g. via a factory_)

#### Summary

- A **prototype** is a partially or fully initialised object that you copy
  (_clone_) and make use of

### Structural Patterns

- Concerned with the structure (_e.g. class members_)
- Many patterns are wrappers that mimic the underlying class' interface
- Stress the importance of good API design

## Behavioural Patterns

- All different; no central theme
- Unique in their approach to solving specific problems