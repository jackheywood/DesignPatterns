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

## Structural Patterns

- Concerned with the structure (_e.g. class members_)
- Many patterns are wrappers that mimic the underlying class' interface
- Stress the importance of good API design

## Behavioural Patterns

- All different; no central theme
- Unique in their approach to solving specific problems