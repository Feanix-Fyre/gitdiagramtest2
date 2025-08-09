# ItemFilter_LegalStatus

Inherits from `ItemFilter`.

## Description

This class is a specific type of `ItemFilter` that filters items based on their `ELegalStatus`.

## Fields

-   **RequiredLegalStatus**: `ELegalStatus`
    -   The specific legal status that an item must have to pass the filter.

## Constructors

### ItemFilter_LegalStatus(ELegalStatus requiredLegalStatus)
Creates a new instance of the filter for a specific legal status.

-   **Parameters:**
    -   `requiredLegalStatus`: The `ELegalStatus` to filter for.

## Methods

### DoesItemMatchFilter
`public override bool DoesItemMatchFilter(ItemInstance instance)`

Overrides the base method to implement the filtering logic. It checks if the `legalStatus` of the item's `Definition` matches the `RequiredLegalStatus`.

-   **Parameters:**
    -   `instance`: The `ItemInstance` to check.
-   **Returns:** `true` if the item's legal status matches, otherwise `false`.
