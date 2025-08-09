# BuildUpdate_StoredItem

Inherits from `BuildUpdate_Base`.

## Description

This class handles the per-frame logic for placing `StorableItem`s (like boxes and crates) onto `StorageGrid`s (like shelves and pallets). It manages the ghost model's position, rotation, and validates its placement against the storage grid.

## Inner Classes

### StorageTileIntersection
A simple class to pair a `FootprintTile` with a `StorageTile`.
-   **footprintTile**: `FootprintTile`
-   **storageTile**: `StorageTile`

## Fields

-   **itemInstance**: `StorableItemInstance` - The item instance being placed.
-   **ghostModel**: `GameObject` - The ghost model preview of the item.
-   **storedItemClass**: `StoredItem` - The `StoredItem` component on the ghost model.
-   **bestIntersection**: `protected StorageTileIntersection` - The closest valid intersection between a footprint tile and a storage tile.
-   **detectionRange**: `float` - The range for detecting surfaces to place on.
-   **detectionMask**: `LayerMask` - The layers to include in placement detection.
-   **currentRotation**: `float` - The current rotation in degrees applied to the object.
-   **validPosition**: `protected bool` - Is the current ghost position a valid placement location?

## Methods

### Update
`protected virtual void Update()`

Checks for rotation input and placement input (`PrimaryClick`). If the position is valid and the player clicks, it calls `Place()`.

### LateUpdate
`protected virtual void LateUpdate()`

The core logic loop for placement. Each frame, it:
1.  Positions the ghost model in front of the player or at the raycast hit point.
2.  Applies the current rotation.
3.  Calls `CheckGridIntersections()` to validate the placement against a `StorageGrid`.
4.  If the position is invalid, it attempts to nudge the ghost model slightly to find a valid spot nearby.
5.  Calls `UpdateMaterials()` to set the ghost material to red or white.

### CheckGridIntersections
`protected virtual void CheckGridIntersections()`

Finds all intersections between the ghost's footprint tiles and existing `StorageTile`s. It identifies the best intersection to snap to and then validates that all footprint tiles have a valid, unoccupied storage tile to sit on. It also handles special rotation logic for snapping to pallets. It sets the `validPosition` flag based on these checks.

### Place
`protected virtual void Place()`

Called when the player confirms a valid placement. It calculates the final rotation, calls `CreateStoredItem` on the `BuildManager`, and calls `PostPlace()`.

### PostPlace
`protected virtual void PostPlace()`

Called after `Place()`. By default, it removes one item from the player's equipped inventory slot.

### CheckRotation & ApplyRotation
`protected void CheckRotation()` and `protected void ApplyRotation()`

Handle player input for rotation and apply it to the ghost model.
