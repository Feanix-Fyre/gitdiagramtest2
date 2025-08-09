# BuildStart_Cash

Inherits from `BuildStart_StoredItem`.

## Description

This class handles the initiation of the building process specifically for placing cash items. It creates the ghost model for the cash and sets up the corresponding `BuildUpdate_Cash` component with the necessary references.

## Methods

### StartBuilding
`public override void StartBuilding(ItemInstance itemInstance)`

Overrides the base `StartBuilding` method. It creates the ghost model for the cash stack, hides the crosshair, and then passes the `itemInstance` and the `ghostModel` to the `BuildUpdate_Cash` component on the same GameObject.

-   **Parameters:**
    -   `itemInstance`: The `ItemInstance` of the cash being placed. It is expected to be a `StorableItemInstance`.
