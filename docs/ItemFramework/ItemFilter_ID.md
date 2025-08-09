# ItemFilter_ID

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that filters items based on a list of item IDs. It can function as either a whitelist (only allowing items in the list) or a blacklist (blocking items in the list).

## Fields

-   **IsWhitelist**: `bool`
    -   If true, the filter acts as a whitelist, and only items whose IDs are in the `IDs` list will pass.
    -   If false, the filter acts as a blacklist, and any item whose ID is in the `IDs` list will be blocked.
-   **IDs**: `List<string>`
    -   The list of item IDs to use for filtering.

## Constructors

### ItemFilter_ID(List<string> ids)
Creates a new instance of the filter with a specified list of IDs. It defaults to being a whitelist.

-   **Parameters:**
    -   `ids`: The list of IDs to use for filtering.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to implement the filtering logic.
-   If `IsWhitelist` is true, it returns `false` if the item's ID is *not* in the `IDs` list.
-   If `IsWhitelist` is false (i.e., it's a blacklist), it returns `false` if the item's ID *is* in the `IDs` list.
-   If the item passes the whitelist/blacklist check, it then calls the base class's `DoesItemMatchFilter` method for any further checks.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item passes the filter, otherwise `false`.
