# QualityItemInstance

Inherits from `StorableItemInstance`.

## Description

This class represents a specific instance of an item that has a quality level. It extends `StorableItemInstance` to include a `Quality` property.

## Fields

-   **Quality**: `EQuality`
    -   The quality level of this specific item instance.

## Constructors

### QualityItemInstance()
An empty constructor, likely for serialization purposes.

### QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality)
Creates a new instance of a quality-based item.

-   **Parameters:**
    -   `definition`: The `QualityItemDefinition` of the item.
    -   `quantity`: The quantity of the item.
    -   `quality`: The `EQuality` for this instance.

## Methods

### CanStackWith
`public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)`

Overrides the base method to add an additional condition for stacking: two `QualityItemInstance`s can only stack if they have the same `Quality` level.

-   **Parameters:**
    -   `other`: The other `ItemInstance` to check against.
    -   `checkQuantities`: If true, the method will also check if the combined stack would exceed the `StackLimit`.
-   **Returns:** `true` if the items have the same ID and quality, otherwise `false`.

### GetCopy
`public override ItemInstance GetCopy(int overrideQuantity = -1)`

Creates a new `QualityItemInstance` that is a copy of this one.

-   **Parameters:**
    -   `overrideQuantity`: If provided, the new copy will have this quantity. Otherwise, it uses the current instance's quantity.
-   **Returns:** A new `QualityItemInstance` with the same properties.

### GetItemData
`public override ItemData GetItemData()`

Creates a `QualityItemData` object for serialization, capturing the item's ID, quantity, and quality level.

-   **Returns:** A `QualityItemData` object containing this instance's data.

### SetQuality
`public void SetQuality(EQuality quality)`

Sets the `Quality` of the item and invokes the `onDataChanged` event.

-   **Parameters:**
    -   `quality`: The new quality level.
