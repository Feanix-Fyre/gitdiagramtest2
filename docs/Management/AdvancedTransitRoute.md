# AdvancedTransitRoute

Inherits from `TransitRoute`.

## Description

This class represents a more advanced version of a `TransitRoute`, used by employees to move items between two `ITransitEntity` objects (e.g., from a storage shelf to a crafting station). It extends the basic route by adding an item filter, allowing for more specific transit tasks.

## Properties

-   **Filter**: `ManagementItemFilter` (read-only)
    -   An item filter that determines which items are allowed to be moved along this route. It can be configured as a whitelist or a blacklist.

## Constructors

### AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination)
Creates a new advanced route between a source and a destination.

### AdvancedTransitRoute(AdvancedTransitRouteData data)
Creates a new advanced route from saved data, reconstructing the source, destination, and item filter settings.

## Methods

### GetItemReadyToMove
`public ItemInstance GetItemReadyToMove()`

Checks the source entity's output slots for an item that matches the route's `Filter` and for which the destination entity has input capacity.

-   **Returns:** An `ItemInstance` representing the item and quantity that can be moved, or `null` if no valid item can be moved at this time.

### GetData
`public AdvancedTransitRouteData GetData()`

Creates and returns a serializable `AdvancedTransitRouteData` object containing the current state of this route, used for saving the game.
