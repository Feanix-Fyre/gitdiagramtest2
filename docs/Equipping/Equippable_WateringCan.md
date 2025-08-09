# Equippable_WateringCan

Inherits from `Equippable_Pourable`.

## Description

This class represents an equippable watering can. It extends `Equippable_Pourable` with logic specific to watering plants in a `Pot`, including checking if the can has water and if the pot needs watering. It also controls the visual fill level of the watering can model.

## Fields

-   **Visuals**: `WateringCanVisuals`
    -   A reference to the component that controls the visual appearance of the water inside the can.
-   **WCInstance**: `private WateringCanInstance`
    -   A cached reference to the `WateringCanInstance` from the inventory.

## Properties

-   **InteractionLabel**: `string` (override)
    -   Sets the interaction prompt text to "Pour water".

## Methods

### Equip
`public override void Equip(ItemInstance item)`

Overrides the base method. It caches the `WateringCanInstance`, updates the visual fill level, and subscribes the `UpdateVisuals` method to the item's `onDataChanged` event so the visuals stay in sync with the item's data.

### Unequip
`public override void Unequip()`

Overrides the base method to unsubscribe from the `onDataChanged` event to prevent memory leaks.

### UpdateVisuals
`private void UpdateVisuals()`

Calls `Visuals.SetFillLevel` to update the visual representation of the water in the can based on the `CurrentFillAmount` of the `WCInstance`.

### CanPour
`protected override bool CanPour(Pot pot, out string reason)`

Overrides the base method to add specific validation checks for watering. The can can be poured if:
1.  The target `pot` has soil.
2.  The `pot` is not already full of water.
3.  The watering can itself is not empty.

-   **Parameters:**
    -   `pot`: The target `Pot`.
    -   `reason`: An `out` parameter for displaying a message if the action is invalid.
-   **Returns:** `true` if the pot can be watered, otherwise `false`.

### StartPourTask
`protected override void StartPourTask(Pot pot)`

Overrides the base method to start a new `PourWaterTask`, which handles the logic for watering the `pot`.
