# ConstructUpdate_OutdoorGrid

Inherits from `ConstructUpdate_Base`.

## Description

This class handles the per-frame logic for placing or moving grid-based items specifically on outdoor grids. It manages the ghost model's position, rotation, and validates its placement against the outdoor grid tiles.

## Fields

-   **detectionMask**: `LayerMask` - The layers to include in placement detection raycasts.
-   **ConstructableClass**: `Constructable_GridBased` - The `Constructable_GridBased` component on the ghost model.
-   **GhostModel**: `Transform` - The transform of the ghost model preview.
-   **validPosition**: `protected bool` - Is the current ghost position a valid placement location?
-   **currentRotation**: `public float` - The current rotation in degrees applied to the object.
-   **closestIntersection**: `protected ConstructionManager.WorldIntersection` - The closest valid intersection between a footprint tile and a world grid tile.

## Core Logic

1.  **Input Handling (`Update`)**:
    -   It listens for rotation input to update `currentRotation`.
    -   On a primary click, if the position is valid and financial requirements are met, it calls either `PlaceNewConstructable` or `FinalizeMoveConstructable`.

2.  **Ghost Model Placement (`LateUpdate`)**:
    -   It raycasts from the mouse position to find a point in the world.
    -   The `GhostModel` is moved to this point.
    -   `ApplyRotation` is called to orient the model based on `currentRotation`.
    -   `CheckTileIntersections` is called to snap the model to the nearest outdoor grid tile and validate the placement.
    -   `UpdateMaterials` is called to set the ghost's material to red or white based on validity.

3.  **Placement Validation (`CheckTileIntersections`)**:
    -   Finds all intersections between the ghost's footprint tiles and `OutdoorTile`s.
    -   Snaps the ghost model's position to the closest valid intersection.
    -   Iterates through all footprint tiles to ensure each one corresponds to a valid and unoccupied grid tile.
    -   Sets `validPosition` to `true` or `false` based on the outcome.

## Key Methods

### PlaceNewConstructable
`protected virtual Constructable_GridBased PlaceNewConstructable()`

Called when placing a new object. It calls `CreateConstructable_GridBased` on the `ConstructionManager`, deducts the cost from the player's balance, and, if Shift is not held, clears the selection in the `ConstructionMenu`.

### FinalizeMoveConstructable
`protected virtual void FinalizeMoveConstructable()`

Called when moving an existing object. It calls `RepositionConstructable` on the object being moved, then tells the `ConstructionManager` to stop the move process.

### AreMetaReqsMet
`private bool AreMetaReqsMet()`

Checks if the player can afford to place the new object. Always returns `true` if an object is being moved.
