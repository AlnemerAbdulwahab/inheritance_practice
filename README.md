# Inheritance Practice - C# Class Hierarchy

A C# console application demonstrating inheritance concepts through a multi-level class hierarchy. This project showcases parent-child relationships, constructor chaining, method overriding, and polymorphism as learned in the Tuwaiq Academy Software Development Bootcamp.

## Project Overview

This application implements a class hierarchy where classes inherit from each other in different patterns, demonstrating how inheritance works in C# and how constructors and methods propagate through the inheritance chain.

## Class Hierarchy
```
        A (Parent)
       / \
      B   E (Children of A, Siblings)
      |   |
      C   D (Grandchildren)
```

### Inheritance Relationships
- **A**: Base/parent class
- **B**: Child of A (has method override with base call)
- **E**: Child of A (inherits method without override)
- **C**: Child of B, Grandchild of A (has method override without base call)
- **D**: Child of E, Grandchild of A (has method override without base call)

## Features

### 1. **Constructor Chaining**
All classes demonstrate constructor chaining using `base()`:
```csharp
public B() : base() {
    Console.WriteLine("B constructor");
}
```

When creating object `C`, the constructor chain is:
```
A constructor → B constructor → C constructor
```

### 2. **Method Overriding**
- **Class A**: Defines `virtual void x()` - can be overridden
- **Class B**: Overrides `x()` and calls `base.x()` - extends parent behavior
- **Class C**: Overrides `x()` without `base.x()` - replaces parent behavior completely
- **Class E**: Inherits `x()` from A without overriding - uses parent behavior as-is
- **Class D**: Overrides `x()` without `base.x()` - replaces parent behavior

### 3. **Virtual and Override Keywords**
```csharp
// Parent class uses 'virtual'
public virtual void x() { }

// Child class uses 'override'
public override void x() { }
```

## OOP Concepts Demonstrated

### 1. Inheritance
- Single inheritance (C# allows one direct parent)
- Multi-level inheritance (A → B → C)
- Sibling classes (B and E both inherit from A)

### 2. Polymorphism
- Method overriding with different implementations
- Virtual methods that can be customized by children
- Base class reference to derived class objects

### 3. Constructor Behavior
- Parent constructor always runs before child constructor
- Explicit `base()` calls to parent constructors
- Constructor chain follows inheritance hierarchy

### 4. Method Resolution
- **With base.x()**: Parent method runs, then child method
- **Without base.x()**: Only child method runs
- **No override**: Parent method runs (inherited as-is)

## Installation & Setup

### Prerequisites
- .NET 6.0 SDK or higher

### Steps

1. **Clone the repository**
```bash
git clone https://github.com/AlnemerAbdulwahab/inheritance_practice.git
cd inheritance_practice
```

2. **Run the application**
```bash
dotnet run
```

## Project Structure
```
inheritance_practice/
├── README.md
├── inheritance.cs           # Main code with all classes
```

## Sample Output
```
Creating A:
A constructor
A's x method

Creating B:
A constructor
B constructor
A's x method
B's x method

Creating C:
A constructor
B constructor
C constructor
C's x method

Creating E:
A constructor
E constructor

Creating D:
A constructor
E constructor
D constructor
D's x method
```

## Output Analysis

### Creating Class A
```
A constructor
A's x method
```
- Only A's constructor runs
- A's x method executes

### Creating Class B
```
A constructor          ← Parent constructor runs first
B constructor          ← Then child constructor
A's x method          ← base.x() calls parent method
B's x method          ← Then B's own method runs
```

### Creating Class C
```
A constructor          ← Grandparent constructor
B constructor          ← Parent constructor
C constructor          ← Own constructor
C's x method          ← Only C's method (no base.x() call)
```

### Creating Class E
```
A constructor          ← Parent constructor runs
E constructor          ← Own constructor
(No x method call - E inherits A's x but doesn't override it)
```

### Creating Class D
```
A constructor          ← Grandparent constructor
E constructor          ← Parent constructor
D constructor          ← Own constructor
D's x method          ← Only D's method (no base.x() call)
```

## Key Learning Points

### 1. Constructor Chain Always Runs Bottom-Up
When you create an object of class C:
1. A's constructor runs first (grandparent)
2. B's constructor runs second (parent)
3. C's constructor runs last (self)

### 2. Method Override Behavior

| Class | Override? | Calls base? | Result |
|-------|-----------|-------------|--------|
| A | Original | N/A | "A's x method" |
| B | Yes | Yes | "A's x method" + "B's x method" |
| C | Yes | No | "C's x method" only |
| E | No | N/A | Uses A's x method |
| D | Yes | No | "D's x method" only |

### 3. Virtual vs Override
- `virtual`: Tells compiler "this method can be overridden by children"
- `override`: Tells compiler "I'm replacing/extending parent's method"
- Without `override`, child method would **hide** parent method (not recommended)

### 4. Base Keyword Usage
```csharp
// In constructor
public B() : base() { }  // Calls parent constructor

// In method
public override void x() {
    base.x();  // Calls parent's x method
    // Then do additional work
}
```

## Inheritance Patterns Demonstrated

### Pattern 1: Extending Parent Behavior (Class B)
```csharp
public override void x() {
    base.x();  // Do what parent does
    Console.WriteLine("B's x method");  // Then add more
}
```

### Pattern 2: Replacing Parent Behavior (Classes C & D)
```csharp
public override void x() {
    // Don't call base.x()
    Console.WriteLine("C's x method");  // Completely new behavior
}
```

### Pattern 3: Inheriting Parent Behavior (Class E)
```csharp
// No override, just use parent's method as-is
```

## Practical Applications

This inheritance pattern is useful for:
- **UI Components**: Button → IconButton → AnimatedButton
- **Data Models**: Entity → User → AdminUser
- **Game Objects**: GameObject → Character → Player/Enemy
- **File Systems**: FileSystemItem → File/Directory
- **Vehicles**: Vehicle → Car/Motorcycle → ElectricCar


## About

This project was created as part of the Tuwaiq Academy Software Development Bootcamp as a hands-on exercise to practice and understand inheritance in C#. The code demonstrates fundamental inheritance concepts including:
- Parent-child class relationships
- Constructor chaining with `base()`
- Method overriding with `virtual` and `override`
- The behavior of `base.x()` calls
- Multi-level inheritance hierarchies

The primary objective was to understand how inheritance works, how constructors propagate through the class hierarchy, and the different patterns of method overriding.
