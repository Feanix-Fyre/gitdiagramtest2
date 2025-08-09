# ItemFilter_UnpackagedProduct

Inherits from `ItemFilter_Category`.

## Description

This class is a specific type of `ItemFilter` that only allows items that are products *and* have **not** been packaged.

## Constructors

### ItemFilter_UnpackagedProduct()
The constructor calls the base `ItemFilter_Category` constructor, passing it a list containing only `EItemCategory.Product`. This ensures that the filter will only ever consider items in the "Product" category.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to add more specific filtering logic. It checks two conditions:
1.  Is the `instance` a `ProductItemInstance`?
2.  Does that `ProductItemInstance` have a `null` `AppliedPackaging`?

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item is an unpackaged product, otherwise `false`.
