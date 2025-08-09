# CashDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines a cash item. Its primary purpose is to ensure that when a new instance of this item is created, it is specifically a `CashInstance`.

## Methods

### GetDefaultInstance
`public override ItemInstance GetDefaultInstance(int quantity = 1)`

Overrides the base method to create and return a new `CashInstance`.

-   **Parameters:**
    -   `quantity`: The quantity for the new instance.
-   **Returns:** A new `CashInstance` based on this definition.
