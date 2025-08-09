# ClothingInstance

Inherits from `StorableItemInstance`.

## Description

This class represents a specific instance of a piece of clothing. It extends `StorableItemInstance` to include a `Color` property, allowing each piece of clothing to have a specific color assigned to it.

## Fields

-   **Color**: `EClothingColor`
    -   The color of this specific clothing instance.

## Properties

-   **Name**: `string` (override)
    -   Overrides the base `Name` property to append the color's label in parentheses if the color is not white (e.g., "T-Shirt (Red)").

## Constructors

### ClothingInstance()
An empty constructor, likely for serialization purposes.

### ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color)
Creates a new instance of a clothing item.

-   **Parameters:**
    -   `definition`: The `ClothingDefinition` of the item.
    -   `quantity`: The quantity of the item.
    -   `color`: The `EClothingColor` for this instance.

## Methods

### GetCopy
`public override ItemInstance GetCopy(int overrideQuantity = -1)`

Creates a new `ClothingInstance` that is a copy of this one.

-   **Parameters:**
    -   `overrideQuantity`: If provided, the new copy will have this quantity. Otherwise, it uses the current instance's quantity.
-   **Returns:** A new `ClothingInstance` with the same properties.

### GetItemData
`public override ItemData GetItemData()`

Creates a `ClothingData` object for serialization, capturing the item's ID, quantity, and color. This is used for saving the game state.

-   **Returns:** A `ClothingData` object containing this instance's data.
