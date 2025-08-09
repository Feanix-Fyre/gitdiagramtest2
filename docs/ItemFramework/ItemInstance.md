# ItemInstance

An abstract class representing a specific instance of an item in the game world or an inventory.

## Description

This is the base class for all items that can exist as an instance (i.e., not just a definition). It holds the item's `ID` and `Quantity`, and provides a reference to its `ItemDefinition` via the `Registry`. It also includes base functionality for stacking, copying, and serialization.

## Fields

-   **ID**: `string` - The unique string identifier of the item type. This is used to look up the `ItemDefinition` in the `Registry`.
-   **Quantity**: `int` - How many of this item are in this stack.
-   **onDataChanged**: `Action` - An event invoked whenever the instance's data (like `Quantity`) changes.
-   **requestClearSlot**: `Action` - An event that can be invoked to request that the `ItemSlot` holding this instance be cleared.

## Properties

-   **Definition**: `ItemDefinition` (read-only) - Lazily loads and returns the `ItemDefinition` associated with this instance's `ID`.
-   **Name / Description / Icon / etc.**: (read-only) - A series of pass-through properties that return the corresponding value from the `Definition`.

## Constructors

### ItemInstance()
An empty constructor, likely for serialization purposes.

### ItemInstance(ItemDefinition definition, int quantity)
Creates a new item instance from a definition and quantity.

## Methods

### CanStackWith
`public virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)`

Checks if this item instance can be stacked with another. By default, items can stack if they have the same `ID` and the combined quantity does not exceed the `StackLimit`.

-   **Parameters:**
    -   `other`: The other `ItemInstance` to check against.
    -   `checkQuantities`: If true, the method will also check if the combined stack would exceed the `StackLimit`.
-   **Returns:** `true` if the items can be stacked.

### GetCopy
`public virtual ItemInstance GetCopy(int overrideQuantity = -1)`

An abstract-like method that must be overridden by derived classes to create a new `ItemInstance` that is a copy of this one. The base implementation logs an error.

### IsValidInstance
`public virtual bool IsValidInstance()`

Checks if the instance is valid (has a non-empty ID, a valid Definition, and a quantity greater than zero).

### SetQuantity / ChangeQuantity
`public void SetQuantity(int quantity)` and `public void ChangeQuantity(int change)`

Methods to safely set or modify the `Quantity` of the item, ensuring it does not go below zero or above the `StackLimit`, and invoking the `onDataChanged` event.

### GetItemData
`public virtual ItemData GetItemData()`

Creates a serializable `ItemData` object from this instance's data, used for saving the game.

### GetMonetaryValue
`public virtual float GetMonetaryValue()`

Returns the monetary value of the item. The base implementation returns 0 and is intended to be overridden by specific item types like `CashInstance`.
