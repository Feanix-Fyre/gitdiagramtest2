# ItemGiver

Inherits from `MonoBehaviour`.

## Description

A simple utility component that gives a specified item to the player when its `Give()` method is called. This is useful for setting up quest rewards, initial item loadouts, or debug tools.

## Fields

-   **Item**: `ItemDefinition`
    -   The `ItemDefinition` of the item to be given.
-   **Quantity**: `int`
    -   The amount of the item to give.

## Methods

### Give
`public void Give()`

Creates a new default instance of the specified `Item` with the given `Quantity` and adds it to the player's inventory via the `PlayerInventory` singleton.
