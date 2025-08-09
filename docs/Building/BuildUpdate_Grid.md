# BuildUpdate_Grid

Inherits from `BuildUpdate_Base`.

## Description

This class handles the per-frame logic for placing grid-based items. It manages the position and rotation of the ghost model, checks for valid placement locations on a `Grid`, and handles player input for rotation and placement.

## Fields

-   **GhostModel**: `GameObject` - The ghost model preview of the item being built.
-   **BuildableItemClass**: `GridItem` - The `GridItem` component on the ghost model.
-   **ItemInstance**: `ItemInstance` - The item instance being built.
-   **CurrentRotation**: `float` - The current rotation in degrees applied to the object.
-   **detectionRange**: `float` - The range for detecting surfaces to place on.
-   **detectionMask**: `LayerMask` - The layers to include in placement detection.
-   **AllowRotation**: `bool` - Whether the player is allowed to rotate the item.
-   **validPosition**: `protected bool` - Is the current ghost position a valid placement location?
-   **closestIntersection**: `protected TileIntersection` - The closest valid tile intersection for snapping.

## Methods

### Update
`protected virtual void Update()`

Checks for rotation input and placement input (`PrimaryClick`). If the position is valid and the player clicks, it calls `Place()`.

### LateUpdate
`protected virtual void LateUpdate()`

This is the core logic loop for placement. Each frame, it:
1.  Positions the ghost model in front of the player.
2.  Snaps the ghost model to the ground or a surface via raycasting.
3.  Applies the current rotation.
4.  Corrects for the object penetrating other colliders.
5.  Calls `CheckIntersections()` to validate the grid position.
6.  Applies a slight vertical offset to make invalid placements "pop up".
7.  Calls `UpdateMaterials()` to set the ghost material to red or white based on `validPosition`.

### CheckIntersections
`protected virtual void CheckIntersections()`

A complex method that determines if the ghost model's footprint can be legally placed on the grid. It checks:
-   If all footprint tiles are over valid grid tiles.
-   If any of the target grid tiles are already occupied.
-   If any corner obstacles are blocked.
-   It sets the `validPosition` flag based on these checks.

### Place
`protected virtual void Place()`

Called when the player confirms a valid placement. It calculates the final rotation, calls `CreateGridItem` on the `BuildManager`, removes the item from the player's inventory, and plays a placement sound.

### CheckRotation
`protected void CheckRotation()`

Handles player input for rotating the object left or right in 90-degree increments.

### ApplyRotation
`protected void ApplyRotation()`

Applies the `CurrentRotation` to the `GhostModel`'s transform, taking the parent grid's rotation into account.

### UpdateMaterials
`protected void UpdateMaterials()`

Sets the ghost model's material to the red or white ghost material from the `BuildManager` based on the `validPosition` flag.
