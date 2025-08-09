# BuildStart_StoredItem

Inherits from `BuildStart_Base`.

## Description

This class handles the initiation of the building process for placing `StorableItem`s (e.g., boxes, crates) into the world. It creates the ghost model and sets up the `BuildUpdate_StoredItem` component to handle the placement logic.

## Methods

### StartBuilding
`public override void StartBuilding(ItemInstance itemInstance)`

Overrides the base `StartBuilding` method. This method:
1.  Calls `CreateGhostModel` to instantiate a preview version of the storable item.
2.  Hides the HUD crosshair.
3.  Passes the ghost model and item instance to the `BuildUpdate_StoredItem` component on the same GameObject.

-   **Parameters:**
    -   `itemInstance`: The `ItemInstance` of the storable item being placed. It is expected to be a `StorableItemInstance`.

### CreateGhostModel
`protected virtual GameObject CreateGhostModel(StorableItemInstance item)`

Instantiates and prepares a "ghost" model of the storable item to be placed. This involves:
-   Calling the `CreateGhostModel` method on the `StoredItem` prefab itself.
-   Disabling colliders and sprite renderers on the ghost object.
-   Applying the white "ghost" material to indicate a valid placement state initially.
-   Hiding the object's footprint tiles.

-   **Parameters:**
    -   `item`: The `StorableItemInstance` to create a ghost model for.
-   **Returns:** The newly created ghost model `GameObject`.
