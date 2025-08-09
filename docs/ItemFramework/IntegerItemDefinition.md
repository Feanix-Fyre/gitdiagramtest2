# IntegerItemDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines an item that needs to store a single integer value (e.g., ammunition in a magazine). It ensures that when a new instance of this item is created, it is an `IntegerItemInstance` initialized with a default value.

## Fields

-   **DefaultValue**: `int`
    -   The integer value that a new instance of this item will have by default.

## Methods

### GetDefaultInstance
`public override ItemInstance GetDefaultInstance(int quantity = 1)`

Overrides the base method to create and return a new `IntegerItemInstance`, passing it the `DefaultValue`.

-   **Parameters:**
    -   `quantity`: The quantity for the new instance.
-   **Returns:** A new `IntegerItemInstance` based on this definition.
