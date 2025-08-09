# CornerObstacle

Inherits from `MonoBehaviour`.

## Description

This component defines an obstacle at the corner of a `FootprintTile`. It is used by the building system to prevent items from being placed in a way that would block or clip into the corners of other, already-placed items.

## Fields

-   **obstacleEnabled**: `bool`
    -   A flag to enable or disable this corner obstacle check.
-   **parentFootprint**: `FootprintTile`
    -   A reference to the `FootprintTile` that this corner belongs to.
-   **coordinates**: `Vector2`
    -   The local coordinates of this corner relative to its parent footprint tile.

## Methods

### GetNeighbourTiles
`public List<Tile> GetNeighbourTiles(Tile pairedTile)`

Finds all the grid tiles that are neighbours to this corner. When a `GridItem` is being placed, this method is called on the corners of already-placed items to see if the new item's footprint would occupy all neighbours of a corner, which would indicate an invalid placement.

-   **Parameters:**
    -   `pairedTile`: The grid tile that this corner's parent footprint tile is currently paired with.
-   **Returns:** A list of all grid `Tile`s that are adjacent to this corner point.
