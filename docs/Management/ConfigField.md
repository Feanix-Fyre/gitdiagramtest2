# ConfigField

An abstract base class for all configuration fields used in the management UI.

## Description

This class provides the fundamental structure for different types of configuration fields (e.g., `ObjectField`, `NPCField`, `NumberField`). Each `ConfigField` belongs to a parent `EntityConfiguration` and is responsible for managing a specific piece of data within that configuration.

## Properties

-   **ParentConfig**: `EntityConfiguration` (read-only)
    -   A reference to the `EntityConfiguration` that owns this field.

## Constructors

### ConfigField(EntityConfiguration parentConfig)
The base constructor. It sets the `ParentConfig` and adds itself to the parent's list of fields.

## Abstract Methods

### IsValueDefault
`public abstract bool IsValueDefault()`

An abstract method that must be implemented by derived classes. It should return `true` if the field's current value is its default value, and `false` otherwise. This is likely used to determine if the configuration has been changed from its default state.
