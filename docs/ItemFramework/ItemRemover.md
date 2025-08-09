# ItemRemover

Inherits from `MonoBehaviour`.

## Description

A simple utility component that removes a specified item from the player's inventory when its `Remove()` method is called. This is the counterpart to `ItemGiver` and is useful for things like quest requirements or item consumption events.

## Fields

-   **Item**: `ItemDefinition`
    -   The `ItemDefinition` of the item to be removed.
-   **Quantity**: `int`
    -   The amount of the item to remove.

## Methods

### Remove
`public void Remove()`

Calls `RemoveAmountOfItem` on the `PlayerInventory` singleton to remove the specified `Quantity` of the `Item` from the player's inventory.
