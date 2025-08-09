# TileIntersection

A simple class used in the building system.

## Description

This class acts as a data container to represent an intersection between a `FootprintTile` (from a ghost model) and a `Tile` (from a grid in the world). It is used to determine where a buildable object can be placed.

## Fields

-   **footprint**: `FootprintTile`
    -   The footprint tile from the item being placed.
-   **tile**: `Tile`
    -   The grid tile in the world that the footprint is intersecting with.
