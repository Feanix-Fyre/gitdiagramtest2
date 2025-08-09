# BuildStart_ProceduralGrid

Inherits from `BuildStart_Base`.

## Description

This class handles the initiation of the building process for items that are placed on a procedural grid (e.g., walls, fences). It creates the ghost model, configures it for procedural placement, and sets up the `BuildUpdate_ProceduralGrid` component to manage the placement logic.

## Methods

### StartBuilding
`public override void StartBuilding(ItemInstance itemInstance)`

Overrides the base `StartBuilding` method. This method:
1.  Calls `CreateGhostModel` to instantiate a preview version of the item.
2.  Hides the HUD crosshair.
3.  Loads the "building" input prompts module.
4.  Sets the `tileDetectionMode` on all footprint tiles to `ProceduralTile`.
5.  Passes the ghost model and item instance to the `BuildUpdate_ProceduralGrid` component on the same GameObject.

-   **Parameters:**
    -   `itemInstance`: The `ItemInstance` of the procedural grid item being built.

### CreateGhostModel
`protected virtual ProceduralGridItem CreateGhostModel(BuildableItemDefinition itemDefinition)`

Instantiates and prepares a "ghost" model of the procedural item to be built. This involves:
-   Instantiating the prefab from the `itemDefinition`.
-   Disabling various components on the ghost object that are not needed for a preview (colliders, networking, navigation).
-   Hiding the object's footprint tiles.
-   Setting the `isGhost` flag on the `ProceduralGridItem` component to true.

-   **Parameters:**
    -   `itemDefinition`: The definition of the item to create a ghost model for.
-   **Returns:** The `ProceduralGridItem` component of the newly created ghost model.
