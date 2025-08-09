# Equippable_StorableItem

Inherits from `Equippable`.

## Description

This class represents an equippable item that can be placed in a storage container (like a shelf or pallet). It acts as a bridge between the inventory/equipping system and the `BuildManager` for placing items into storage.

## Fields

-   **isBuildingStoredItem**: `protected bool`
    -   A flag to track whether the `BuildManager` is currently active for placing this item into storage.
-   **lookingAtStorageObject**: `protected bool`
    -   A flag indicating if the player is currently looking at a valid storage container.
-   **rotation**: `protected float`
    -   Stores the item's rotation value, preserving it when switching between building and non-building states.

## Core Logic

The `Update` method contains the core logic for toggling the storage placement mode.

1.  `CheckLookingAtStorageObject()` is called. (Note: The base implementation of this method is empty and seems to be overridden by derived classes, though none are shown here. It's presumed to set `lookingAtStorageObject` to true if the player is aiming at a valid storage container).
2.  If `lookingAtStorageObject` is true and the system is not already in placement mode, `StartBuildingStoredItem()` is called.
3.  If `lookingAtStorageObject` is false but the system *was* in placement mode, `StopBuildingStoredItem()` is called.

## Methods

### StartBuildingStoredItem
`protected virtual void StartBuildingStoredItem()`

Initiates the storage placement process. It sets the `isBuildingStoredItem` flag and calls `Singleton<BuildManager>.Instance.StartBuildingStoredItem(itemInstance)`, which creates the ghost model for the item.

### StopBuildingStoredItem
`protected virtual void StopBuildingStoredItem()`

Cancels the storage placement process. It saves the current rotation of the ghost model and calls `Singleton<BuildManager>.Instance.StopBuilding()` to clean up.

### Unequip
`public override void Unequip()`

Overrides the base `Unequip` method. If the player unequips the item while they are in the middle of placing it, this method calls `Singleton<BuildManager>.Instance.StopBuilding()` to cancel the process.
