# BuildStart_Surface

Inherits from `BuildStart_Base`.

## Description

This class handles the initiation of the building process for items that can be placed on surfaces (like tables or countertops). It creates the ghost model and sets up the `BuildUpdate_Surface` component to handle the placement logic.

## Methods

### StartBuilding
`public override void StartBuilding(ItemInstance itemInstance)`

Overrides the base `StartBuilding` method. This method:
1.  Calls `CreateGhostModel` to instantiate a preview version of the surface item.
2.  Hides the HUD crosshair.
3.  Loads the "building" input prompts module.
4.  Passes the ghost model and item instance to the `BuildUpdate_Surface` component on the same GameObject.

-   **Parameters:**
    -   `itemInstance`: The `ItemInstance` of the surface item being built.

### CreateGhostModel
`protected virtual SurfaceItem CreateGhostModel(BuildableItemDefinition itemDefinition)`

Instantiates and prepares a "ghost" model of the surface item to be built. This involves:
-   Instantiating the prefab from the `itemDefinition`.
-   Disabling various components on the ghost object that are not needed for a preview (colliders, networking, navigation, canvases).
-   Activating any child GameObjects that have the `ActivateDuringBuild` component.
-   Setting the `isGhost` flag on the `SurfaceItem` component to true.

-   **Parameters:**
    -   `itemDefinition`: The definition of the item to create a ghost model for.
-   **Returns:** The `SurfaceItem` component of the newly created ghost model.
