# Uninitialized Property Access in C#

This repository demonstrates a common error in C# programming: accessing a property before it's been assigned a value.  This can lead to unpredictable behavior, depending on the context and whether the property has a default value. The code shows how to reproduce this issue and provides a simple solution.

## The Problem

The `ExampleClass` contains a property `MyProperty`. The constructor initializes it. However, in `MyMethod`, we access `MyProperty` before ensuring it has been assigned a value, which can lead to unexpected behavior in specific scenarios.