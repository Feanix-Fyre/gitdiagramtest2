# StorableItemDefinition

Inherits from `ItemDefinition`.

## Description

A `ScriptableObject` that defines an item that can be stored in a physical storage container (like a shelf or pallet), as opposed to just existing in the player's abstract inventory. It adds properties related to purchasing, reselling, and the item's physical representation in the world.

## Fields

-   **BasePurchasePrice**: `float`
    -   The base price to buy this item from a shop.
-   **ShopCategories**: `List<ShopListing.CategoryInstance>`
    -   A list of shop categories this item will appear in.
-   **RequiresLevelToPurchase**: `bool`
    -   If true, the player must reach `RequiredRank` before they can purchase this item.
-   **RequiredRank**: `FullRank`
    -   The rank required to purchase the item if `RequiresLevelToPurchase` is true.
-   **ResellMultiplier**: `float`
    -   A multiplier (0.0 to 1.0) applied to the `BasePurchasePrice` to determine its resell value.
-   **StoredItem**: `StoredItem`
    -   A reference to the prefab that represents this item when it is placed in a storage container.
-   **StationItem**: `StationItem`
    -   An optional reference to a prefab that represents this item when it is used at a crafting station.

## Properties

-   **IsPurchasable**: `bool` (read-only)
    -   Checks if the player meets the rank requirement (if any) to purchase this item.

## Methods

### GetDefaultInstance
`public override ItemInstance GetDefaultInstance(int quantity = 1)`

Overrides the base method to create and return a new `StorableItemInstance`.

-   **Parameters:**
    -   `quantity`: The quantity for the new instance.
-   **Returns:** A new `StorableItemInstance` based on this definition.
