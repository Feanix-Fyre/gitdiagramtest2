# BuildUpdate_Surface

Inherits from `BuildUpdate_Base`.

## Description

This class handles the per-frame logic for placing items on `Surface` objects (like tables, countertops, etc.). It manages the ghost model's position and rotation, raycasting to find valid surfaces, and checking placement validity.

## Fields

-   **GhostModel**: `GameObject` - The ghost model preview of the item being built.
-   **BuildableItemClass**: `SurfaceItem` - The `SurfaceItem` component on the ghost model.
-   **ItemInstance**: `ItemInstance` - The item instance being built.
-   **CurrentRotation**: `float` - The current rotation in degrees applied to the object.
-   **DetectionMask**: `LayerMask` - The layers to include in placement detection.
-   **validPosition**: `protected bool` - Is the current ghost position a valid placement location?
-   **hoveredValidSurface**: `protected Surface` - The valid surface the player is currently aiming at.

## Properties

-   **detectionRange**: `private float` - The maximum distance to raycast for a valid surface.

## Methods

### Update
`protected virtual void Update()`

Checks for rotation input and placement input (`PrimaryClick`). If the position is valid and the player clicks, it calls `Place()`.

### LateUpdate
`protected virtual void LateUpdate()`

The core logic loop for placement. Each frame, it:
1.  Positions the ghost model in front of the player.
2.  Raycasts to find a `Surface` component.
3.  Calls `IsSurfaceValidForItem` to check if the item can be placed on the found surface.
4.  Corrects for the ghost model penetrating other colliders.
5.  Calls `UpdateMaterials` to set the ghost material to red or white based on `validPosition`.

### PositionObjectInFrontOfPlayer
`protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)`

Positions and orients the ghost model based on the player's view and raycast results. It aligns the ghost model to the normal of the surface it hits.

### IsSurfaceValidForItem
`private bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)`

Checks if a given surface is a valid placement target for the current item. It verifies:
-   The surface is not null.
-   The item's `ValidSurfaceTypes` list includes the surface's type.
-   The surface is on a property owned by the player.
-   The specific point on the surface is valid (not obstructed).

### Place
`protected virtual void Place()`

Called when the player confirms a valid placement. It calculates the final position and rotation relative to the `hoveredValidSurface` and calls `CreateSurfaceItem` on the `BuildManager`. It also removes the item from the player's inventory and plays a placement sound.

### CheckRotation & UpdateMaterials
`protected void CheckRotation()` and `protected void UpdateMaterials()`

These methods handle player input for rotation and updating the ghost material's color, similar to other `BuildUpdate` scripts.
