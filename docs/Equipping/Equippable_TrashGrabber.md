# Equippable_TrashGrabber

Inherits from `Equippable_Viewmodel`.

## Description

This class controls the functionality of an equippable trash grabber tool. It allows the player to pick up `TrashItem`s from the world and then eject them by holding down the primary mouse button.

## Key Fields & Properties

-   **TrashContent**: `Transform` - The transform of the visual model representing the trash inside the grabber's bin.
-   **TrashContent_Min / TrashContent_Max**: `Transform` - Transforms defining the local position and scale of the `TrashContent` when the bin is empty vs. full.
-   **GrabAnim**: `Animation` - The animation played when trash is picked up.
-   **Bin**: `Transform` - The transform of the bin model itself, which is animated when ejecting trash.
-   **BinRaisedPosition**: `Transform` - A transform defining the target position/rotation/scale of the bin when ejecting.
-   **TrashDropSound**: `AudioSourceController` - A looping sound played while ejecting trash.
-   **onPickup**: `UnityEvent` - An event invoked when a piece of trash is picked up.
-   **Instance**: `static Equippable_TrashGrabber` (read-only) - A static reference to the currently equipped instance.
-   **IsEquipped**: `static bool` (read-only) - A static property to easily check if a trash grabber is currently equipped.

## Core Logic

-   **Equipping**: When equipped, it caches its `TrashGrabberInstance` from the inventory, sets the static `Instance` reference, and subscribes `RefreshVisuals` to the instance's `onDataChanged` event.
-   **Picking Up**: The `PickupTrash` method is called externally (likely by a raycast from another script) when the player targets a `TrashItem`. It plays the grab animation, adds the trash ID to the `trashGrabberInstance`, and destroys the `TrashItem` in the world.
-   **Ejecting (`Update`)**:
    -   When the player holds the primary mouse button, the `Bin` transform animates towards its `BinRaisedPosition`.
    -   The `TrashDropSound` starts playing and fades in.
    -   If the button is held for the full `DropTime`, the `EjectTrash` method is called repeatedly at a fixed interval (`TrashDropSpacing`), spawning trash items in front of the player.
    -   When the button is released, the bin animates back to its default position and the sound fades out.
-   **Visuals (`RefreshVisuals`)**: This method is called whenever the trash content changes. It updates the position and scale of the `TrashContent` model to visually represent how full the bin is.

## Public Methods

### PickupTrash
`public void PickupTrash(TrashItem item)`

Adds a `TrashItem` to the grabber's inventory.

-   **Parameters:**
    -   `item`: The `TrashItem` to be picked up.

### GetCapacity
`public int GetCapacity()`

Calculates and returns the remaining capacity of the trash grabber.
