# BuildStart_Grid

Inherits from `BuildStart_Base`.

## Description

This class handles the initiation of the building process for items that snap to a grid. It is responsible for creating a "ghost" version of the grid item, configuring its tile detectors, and setting up the corresponding `BuildUpdate_Grid` component to handle the placement logic.

## Methods

### StartBuilding
`public override void StartBuilding(ItemInstance itemInstance)`

Overrides the base `StartBuilding` method. This method:
1.  Calls `CreateGhostModel` to instantiate a preview version of the item.
2.  Hides the HUD crosshair.
3.  Configures the `tileDetector` on each `FootprintTile` of the ghost model based on the item's `GridType` (e.g., `IndoorOnly`, `OutdoorOnly`).
4.  Loads the "building" input prompts module.
5.  Passes the ghost model and item instance to the `BuildUpdate_Grid` component on the same GameObject.

-   **Parameters:**
    -   `itemInstance`: The `ItemInstance` of the grid-based item being built.

### CreateGhostModel
`protected virtual GridItem CreateGhostModel(BuildableItemDefinition itemDefinition)`

Instantiates and prepares a "ghost" model of the item to be built. This involves:
-   Instantiating the prefab from the `itemDefinition`.
-   Disabling various components on the ghost object that are not needed for a preview, such as colliders, networking, navigation components, and lights, using methods from the `BuildManager`.
-   Activating any child GameObjects that have the `ActivateDuringBuild` component.
-   Hiding the object's footprint tiles.
-   Setting the `isGhost` flag on the `GridItem` component to true.

-   **Parameters:**
    -   `itemDefinition`: The definition of the item to create a ghost model for.
-   **Returns:** The `GridItem` component of the newly created ghost model.
