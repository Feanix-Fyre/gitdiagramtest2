# IDs

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that filters items based on a whitelist of item IDs.

## Fields

-   **AcceptedIDs**: `List<string>`
    -   A list of item IDs that are allowed to pass through this filter.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to implement the filtering logic. It checks if the `instance.ID` is present in the `AcceptedIDs` list. If it is, it then calls the base class's `DoesItemMatchFilter` method to perform any further checks.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item's ID is in the accepted list and it passes any base filter checks, otherwise `false`.
