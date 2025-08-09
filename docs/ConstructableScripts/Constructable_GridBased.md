# Constructable_GridBased

Inherits from `Constructable`.

## Description

This class extends `Constructable` for objects that are placed on a `Grid`. It manages the object's position, rotation, and relationship with its parent grid. It uses `SyncVar`s to keep this positional data synchronized across the network.

## Key Fields & Properties

-   **buildPoint**: `Transform` - An empty child GameObject used as a reference point for positioning and rotating the object on the grid.
-   **CoordinateFootprintTilePairs**: `List<CoordinateFootprintTilePair>` - A list that defines the object's footprint, mapping local coordinates to the `FootprintTile` prefabs used for placement validation.
-   **ContentContainer**: `Transform` - A reference to the transform that holds any child objects that should be parented to the grid's container (useful for keeping the hierarchy clean).
-   **Grids**: `Grid[]` - An array of any `Grid` components that are children of this object (e.g., a shelf has its own grid for placing items on it).
-   **isPowered**: `bool` (read-only) - True if the object is connected to a power source via its `PowerNode`.
-   **OwnerGrid**: `Grid` (read-only) - The `Grid` this object has been placed on.

## `SyncVar`s

-   **OwnerGridGUID**: `Guid` - The unique ID of the `Grid` this object belongs to.
-   **OriginCoordinate**: `Vector2` - The coordinate on the `OwnerGrid` where the object's origin (its first footprint tile) is placed.
-   **Rotation**: `float` - The rotation of the object on the grid, in degrees.

## Core Logic

1.  **Initialization**: When placed in the world, `InitializeConstructable_GridBased` is called. This calls a `ServerRpc` (`SetData`) to set the `OwnerGridGUID`, `OriginCoordinate`, and `Rotation` `SyncVar`s.
2.  **Data Reception**: When the `SyncVar`s are received by clients (or set on the server), the `ReceiveData` method is triggered.
3.  **Placement Logic (`ReceiveData`)**:
    -   It finds the `OwnerGrid` using the `GUIDManager`.
    -   It sets the object's parent transform to the grid's container.
    -   It calculates all the grid tiles the object will occupy based on its origin, footprint, and rotation.
    -   It validates that all required tiles exist on the grid.
    -   It calls `RefreshTransform` to snap the object's world position and rotation to the grid.
    -   It registers itself as an "occupant" on each grid tile it covers.
4.  **Destruction**: When `DestroyConstructable` is called, it first un-registers itself as an occupant from all the tiles it covers before destroying the object.

## Public Methods

### InitializeConstructable_GridBased
`public virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)`

The primary method for initializing a newly placed grid-based object. It triggers the `SetData` RPC to synchronize its placement data.

### RepositionConstructable
`public virtual void RepositionConstructable(Guid gridGUID, Vector2 originCoordinate, float rotation)`

Allows an existing object to be moved to a new position. It calls the same `SetData` RPC as the initialization method.

### SetRoofVisible
`public virtual void SetRoofVisible(bool vis)`

A method to toggle the visibility of roof objects associated with this constructable. This is used to hide roofs when the player is inside a building.
