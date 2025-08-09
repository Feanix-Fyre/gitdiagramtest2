# Equippable_BuildableItem

Inherits from `Equippable_StorableItem`.

## Description

This class represents an equippable item that can be placed in the world via the building system. It acts as a bridge between the inventory/equipping system and the `BuildManager`.

## Fields

-   **isBuilding**: `protected bool`
    -   A flag to track whether the `BuildManager` is currently active for this item.

## Core Logic

The `Update` method contains the core logic for toggling between two modes: "storing" and "building".

1.  **Storing Mode**:
    -   It uses the `CheckLookingAtStorageObject()` method inherited from `Equippable_StorableItem`.
    -   If the player is looking at a valid storage object, the `isBuilding` flag is set to `false`, and the item behaves like a normal storable item, allowing the player to place it in storage.

2.  **Building Mode**:
    -   If the player is *not* looking at a storage object, and the `isBuilding` flag is false, it means the player wants to build.
    -   The `isBuilding` flag is set to `true`.
    -   It calls `Singleton<BuildManager>.Instance.StartBuilding(itemInstance)` to initiate the building process, which creates the ghost model and handles placement logic.

## Methods

### Unequip
`public override void Unequip()`

Overrides the base `Unequip` method. If the player unequips the item while they are in the middle of placing it, this method calls `Singleton<BuildManager>.Instance.StopBuilding()` to cancel the build process and clean up the ghost model.
