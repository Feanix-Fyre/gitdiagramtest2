# ConstructStart_OutdoorGrid

Inherits from `ConstructStart_Base`.

## Description

This class handles the initiation of the construction process specifically for grid-based items that can only be placed on an outdoor grid. It is responsible for creating the "ghost" model preview and setting up the `ConstructUpdate_OutdoorGrid` component with the necessary references.

## Methods

### StartConstruction
`public override void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)`

Overrides the base method. It performs the following steps:
1.  Calls the base `StartConstruction` method to handle logic for moving objects.
2.  Calls `GenerateGhostModel` to create the visual preview of the item.
3.  Sets the `tileDetectionMode` of all footprint tiles on the ghost model to `OutdoorTile`, ensuring it only snaps to outdoor grids.
4.  Passes the generated `ghostModel` and `constructable` references to the `ConstructUpdate_OutdoorGrid` component on the same GameObject.
5.  If an object is being moved, it preserves its original rotation.

-   **Parameters:**
    -   `constructableID`: The ID of the item being built or moved.
    -   `movedConstructable`: A reference to the object being moved, if applicable.

### GenerateGhostModel
`private void GenerateGhostModel(string id)`

Instantiates and prepares a "ghost" model of the item to be built. This involves:
-   Instantiating the prefab from the `Registry` using its `id`.
-   Getting the `Constructable_GridBased` component from the new instance.
-   Disabling various components on the ghost object that are not needed for a preview (colliders, networking, navigation) by calling methods on the `BuildManager` singleton.
-   Applying the default white "ghost" material.
-   Hiding the object's footprint tiles.
-   Storing a reference to the ghost model's transform.
