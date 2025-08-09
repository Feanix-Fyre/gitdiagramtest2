# BuildUpdate_ProceduralGrid

Inherits from `BuildUpdate_Base`.

## Description

This class handles the per-frame logic for placing items that connect to a procedural grid, such as walls or fences that snap to other, similar pieces. It manages the ghost model's position, rotation, and validates its placement against existing procedural tiles.

## Inner Classes

### Intersection
A simple class to pair a `FootprintTile` with a `ProceduralTile`.
-   **footprintTile**: `FootprintTile`
-   **procTile**: `ProceduralTile`

## Fields

-   **GhostModel**: `GameObject` - The ghost model preview of the item being built.
-   **ItemClass**: `ProceduralGridItem` - The `ProceduralGridItem` component on the ghost model.
-   **ItemInstance**: `ItemInstance` - The item instance being built.
-   **detectionRange**: `float` - The range for detecting surfaces to place on.
-   **detectionMask**: `LayerMask` - The layers to include in placement detection.
-   **validPosition**: `protected bool` - Is the current ghost position a valid placement location?
-   **bestIntersection**: `protected Intersection` - The closest valid intersection between a footprint tile and a procedural tile.

## Methods

### Update
`protected virtual void Update()`

Checks for rotation input and placement input (`PrimaryClick`). If the position is valid and the player clicks, it calls `Place()`.

### LateUpdate
`protected virtual void LateUpdate()`

The core logic loop for placement. Each frame, it:
1.  Positions the ghost model in front of the player or at the raycast hit point.
2.  Applies the current rotation.
3.  Calls `CheckGridIntersections()` to validate the placement against existing procedural tiles.
4.  Calls `UpdateMaterials()` to set the ghost material to red or white based on `validPosition`.

### CheckGridIntersections
`protected virtual void CheckGridIntersections()`

Finds all intersections between the ghost's footprint tiles and existing `ProceduralTile`s in the world. It identifies the best intersection to snap to and then validates that all footprint tiles have a valid, unoccupied, and type-matching procedural tile to connect to. It sets the `validPosition` flag based on these checks.

### Place
`protected void Place()`

Called when the player confirms a valid placement. It gathers a list of all the procedural tiles the new item will connect to, calculates the final rotation, and calls `CreateProceduralGridItem` on the `BuildManager`. It also removes the item from the player's inventory and plays a placement sound.

### IsMatchValid
`private bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)`

Checks if a specific footprint tile can validly connect to a specific procedural tile. The match is valid if the tiles are very close, the procedural tile is unoccupied, and they share the same `ProceduralTileType`.

### CheckRotation & ApplyRotation
`protected void CheckRotation()` and `protected void ApplyRotation()`

Handle player input for rotation and apply it to the ghost model, similar to `BuildUpdate_Grid`.
