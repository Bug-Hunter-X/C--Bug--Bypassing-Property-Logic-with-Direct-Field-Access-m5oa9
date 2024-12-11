# C# Bug: Bypassing Property Logic with Direct Field Access

This repository demonstrates a common, yet subtle bug in C#: directly accessing a private field instead of using its corresponding public property. This can lead to issues if the property has added logic such as validation or logging that is bypassed.  The example shows how to fix it by consistently using the property.

## Bug Description

In the provided code, `MyMethod()` accesses the private field `_myField` directly. If the `MyProperty` setter contained additional logic (e.g., validation, logging, or event handling), this direct access bypasses that logic, potentially leading to unexpected behavior or errors.

## Bug Solution

The solution replaces the direct field access in `MyMethod()` with accessing the `MyProperty`. This ensures that all logic associated with the property is correctly executed.
