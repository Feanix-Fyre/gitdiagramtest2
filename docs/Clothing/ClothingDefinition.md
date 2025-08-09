# ClothingDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines a piece of clothing. It extends the `StorableItemDefinition` with properties specific to clothing, such as the slot it occupies, how it's applied to the avatar, and its color options.

## Fields

-   **Slot**: `EClothingSlot`
    -   The primary slot this clothing item occupies (e.g., `Top`, `Bottom`, `Headwear`).
-   **ApplicationType**: `EClothingApplicationType`
    -   How the clothing is applied to the avatar, such as a body layer texture or an accessory model.
-   **ClothingAssetPath**: `string`
    -   The path to the clothing asset (e.g., the texture for a shirt or the prefab for a hat).
-   **Colorable**: `bool`
    -   Can this item be colored by the player?
-   **DefaultColor**: `EClothingColor`
    -   The default color of the item when it's created.
-   **SlotsToBlock**: `List<EClothingSlot>`
    -   A list of other clothing slots that this item will hide or block when equipped (e.g., a full-body outfit might block the `Top` and `Bottom` slots).

## Methods

### GetDefaultInstance
`public override ItemInstance GetDefaultInstance(int quantity = 1)`

Overrides the base method to create a `ClothingInstance` with the `DefaultColor` when a new instance of this item is needed.

-   **Parameters:**
    -   `quantity`: The quantity of the item (usually 1 for clothing).
-   **Returns:** A new `ClothingInstance` based on this definition.
