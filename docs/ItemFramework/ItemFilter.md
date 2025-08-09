# ItemFilter

A base class for creating item filters.

## Description

This class provides the basic structure for item filtering logic. It is intended to be inherited from by more specific filter classes (e.g., `ItemFilter_Category`, `ItemFilter_ID`). These filters are used in various systems, such as `ItemSlot`s, to determine which items are allowed.

## Methods

### DoesItemMatchFilter
`public virtual bool DoesItemMatchFilter(ItemInstance instance)`

A virtual method that checks if a given `ItemInstance` passes the filter's criteria. The base implementation always returns `true`, meaning it allows all items. Derived classes override this method to implement their specific filtering logic.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item matches the filter, otherwise `false`.
