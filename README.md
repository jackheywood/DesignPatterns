# C# Design Patterns



## Creational Patterns

- Deal with the creation (_construction_) of objects
- Explicit (_constructor_) vs. implicit (_DI, reflection, etc._)
- Wholesale (_single statement_) vs. piecewise (_step-by-step_)

### Builder

- Some objects are simple and can be created in a single constructor call,
other objects require a lot of ceremony to create
- Having an object with 10 constructor arguments is not productive,
opt for **piecewise** construction instead
- **Builder** provides an API for constructing an object step-by-step

## Structural Patterns

- Concerned with the structure (_e.g. class members_)
- Many patterns are wrappers that mimic the underlying class' interface
- Stress the importance of good API design

## Behavioural Patterns

- All different; no central theme
- Unique in their approach to solving specific problems