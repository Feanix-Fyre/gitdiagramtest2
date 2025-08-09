# QualityItemDefinition

Inherits from `StorableItemDefinition`.

## Description

A `ScriptableObject` that defines an item that has a quality level (e.g., harvested plants, crafted products). It ensures that when a new instance of this item is created, it is a `QualityItemInstance` initialized with a default quality.

## Fields

-   **DefaultQuality**: `EQuality`
    -   The quality level that a new instance of this item will have by default.

## Methods

### GetDefaultInstance
`public override ItemInstance GetDefaultInstance(int quantity = 1)`

Overrides the base method to create and return a new `QualityItemInstance`, passing it the `DefaultQuality`.

-   **Parameters:**
    -   `quantity`: The quantity for the new instance.
-   **Returns:** A new `QualityItemInstance` based on this definition.
