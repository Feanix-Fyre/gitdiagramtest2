# Equippable_SurfaceItem

Inherits from `Equippable_StorableItem`.

## Description

This class represents an equippable item that can be placed on a surface (like a table or countertop) via the building system. It acts as a bridge between the inventory/equipping system and the `BuildManager`.

## Fields

-   **isBuilding**: `protected bool`
    -   A flag to track whether the `BuildManager` is currently active for placing this item.

## Core Logic

The `Update` method contains the core logic for toggling between "storing" and "building" modes.
-   It calls `CheckLookingAtStorageObject()` from its parent class. If the player is looking at a valid storage object, it prioritizes that interaction and stops any active building process.
-   If the player is *not* looking at a storage object, and the `isBuilding` flag is false, it means the player wants to place the item on a surface.
-   It sets the `isBuilding` flag to `true`.
-   It calls `Singleton<BuildManager>.Instance.StartBuilding(itemInstance)` to initiate the building process. This is the same method used by `Equippable_BuildableItem`, but the `BuildManager` will use the item's specific `BuildHandler` which will contain a `BuildUpdate_Surface` component to handle the placement logic.

## Methods

### Unequip
`public override void Unequip()`

Overrides the base `Unequip` method. If the player unequips the item while they are in the middle of placing it, this method calls `Singleton<BuildManager>.Instance.StopBuilding()` to cancel the build process and clean up the ghost model.
