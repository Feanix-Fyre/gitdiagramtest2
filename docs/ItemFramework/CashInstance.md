# CashInstance

Inherits from `StorableItemInstance`.

## Description

This class represents a specific instance of a cash item (e.g., a stack of bills). It extends `StorableItemInstance` to include a `Balance` property, representing the monetary value of that specific stack.

## Constants

-   **MAX_BALANCE**: `1E+09f` - The maximum monetary value a single cash instance can hold (one billion).

## Properties

-   **Balance**: `float` (read-only)
    -   The monetary value of this cash instance.

## Constructors

### CashInstance()
An empty constructor, likely for serialization purposes.

### CashInstance(ItemDefinition definition, int quantity)
Creates a new instance of a cash item.

-   **Parameters:**
    -   `definition`: The `CashDefinition` of the item.
    -   `quantity`: The quantity of the item (usually 1 for a stack of cash).

## Methods

### GetCopy
`public override ItemInstance GetCopy(int overrideQuantity = -1)`

Creates a new `CashInstance` that is a copy of this one.

-   **Parameters:**
    -   `overrideQuantity`: If provided, the new copy will have this quantity. Otherwise, it uses the current instance's quantity.
-   **Returns:** A new `CashInstance` with the same properties.

### ChangeBalance
`public void ChangeBalance(float amount)`

Adds or removes from the instance's `Balance`.

-   **Parameters:**
    -   `amount`: The amount to add (can be negative to subtract).

### SetBalance
`public void SetBalance(float newBalance, bool blockClear = false)`

Sets the instance's `Balance` to a specific value. If the balance drops to zero or below, it will request to be cleared from its inventory slot unless `blockClear` is true.

-   **Parameters:**
    -   `newBalance`: The new balance for the instance.
    -   `blockClear`: If true, prevents the item from being removed from inventory when its balance reaches zero.

### GetItemData
`public override ItemData GetItemData()`

Creates a `CashData` object for serialization, capturing the item's ID, quantity, and balance.

-   **Returns:** A `CashData` object containing this instance's data.

### GetMonetaryValue
`public override float GetMonetaryValue()`

Overrides the base method to return the instance's `Balance` as its monetary value.

-   **Returns:** The `Balance` of the cash instance.
