# ItemFilter_Dryable

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that only allows items that can be dried (e.g., in a `DryingRack`).

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to check if the given item is dryable.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if `IsItemDryable` returns true, otherwise `false`.

### IsItemDryable
`public static bool IsItemDryable(ItemInstance instance)`

A static helper method that contains the specific logic for what constitutes a "dryable" item. An item is dryable if:
-   It is an unpackaged marijuana `ProductItemInstance` with a quality less than `Heavenly`.
-   It is a `cocaleaf` `QualityItemInstance` with a quality less than `Heavenly`.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item meets the criteria, otherwise `false`.
