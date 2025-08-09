# ItemFilter_ClothingSlot

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that filters items based on their `EClothingSlot`. It is used to ensure that only items corresponding to a specific clothing slot (e.g., `Top`, `Head`) can be placed in a given `ItemSlot`.

## Properties

-   **SlotType**: `EClothingSlot` (read-only)
    -   The clothing slot that this filter will accept.

## Constructors

### ItemFilter_ClothingSlot(EClothingSlot slot)
Creates a new instance of the filter for a specific clothing slot.

-   **Parameters:**
    -   `slot`: The `EClothingSlot` to filter for.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to implement the filtering logic. It checks two conditions:
1.  Is the `instance` a `ClothingInstance`?
2.  Does the `ClothingDefinition` of the instance have a `Slot` that matches this filter's `SlotType`?

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item is a piece of clothing for the correct slot, otherwise `false`.
