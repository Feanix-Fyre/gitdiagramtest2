# IntegerItemInstance

Inherits from `StorableItemInstance`.

## Description

This class represents a specific instance of an item that needs to store an integer value (e.g., a magazine with a certain number of bullets).

## Fields

-   **Value**: `int`
    -   The integer value associated with this item instance.

## Constructors

### IntegerItemInstance()
An empty constructor, likely for serialization purposes.

### IntegerItemInstance(ItemDefinition definition, int quantity, int value)
Creates a new instance of an integer-based item.

-   **Parameters:**
    -   `definition`: The `IntegerItemDefinition` of the item.
    -   `quantity`: The quantity of the item.
    -   `value`: The initial integer value for this instance.

## Methods

### GetCopy
`public override ItemInstance GetCopy(int overrideQuantity = -1)`

Creates a new `IntegerItemInstance` that is a copy of this one.

-   **Parameters:**
    -   `overrideQuantity`: If provided, the new copy will have this quantity. Otherwise, it uses the current instance's quantity.
-   **Returns:** A new `IntegerItemInstance` with the same properties.

### ChangeValue
`public void ChangeValue(int change)`

Adds or subtracts from the `Value` and invokes the `onDataChanged` event.

-   **Parameters:**
    -   `change`: The amount to add to `Value` (can be negative).

### SetValue
`public void SetValue(int value)`

Sets the `Value` to a specific new value and invokes the `onDataChanged` event.

-   **Parameters:**
    -   `value`: The new integer value.

### GetItemData
`public override ItemData GetItemData()`

Creates an `IntegerItemData` object for serialization, capturing the item's ID, quantity, and integer value.

-   **Returns:** An `IntegerItemData` object containing this instance's data.
