# ItemFilter_MixingIngredient

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that only allows items that are valid ingredients for mixing new products.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to implement the filtering logic. It checks two conditions:
1.  Is the item's definition a `PropertyItemDefinition`? (As only items with properties can be mixed).
2.  Is this `PropertyItemDefinition` present in the `ProductManager`'s `ValidMixIngredients` list?

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item is a valid mixing ingredient, otherwise `false`.
