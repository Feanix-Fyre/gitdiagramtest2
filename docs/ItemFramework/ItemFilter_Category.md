# ItemFilter_Category

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that filters items based on a whitelist of `EItemCategory` enums.

## Fields

-   **AcceptedCategories**: `List<EItemCategory>`
    -   A list of item categories that are allowed to pass through this filter.

## Constructors

### ItemFilter_Category(List<EItemCategory> acceptedCategories)
Creates a new instance of the filter with a specified list of accepted categories.

-   **Parameters:**
    -   `acceptedCategories`: The list of categories to accept.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to implement the filtering logic. It checks if the `instance.Category` is present in the `AcceptedCategories` list.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item's category is in the accepted list, otherwise `false`.
