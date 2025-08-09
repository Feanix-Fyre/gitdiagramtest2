# ItemDefinition

Inherits from `ScriptableObject`.

## Description

This is the base `ScriptableObject` for all item definitions in the game. It contains the fundamental properties that all items share, such as their name, description, ID, and icon. More specific item types (like `StorableItemDefinition` or `ClothingDefinition`) inherit from this class to add their own unique properties.

## Fields

-   **Name**: `string` - The display name of the item.
-   **Description**: `string` - The item's description, shown in the inventory or tooltips.
-   **ID**: `string` - A unique string identifier for this item type (e.g., "pistol_ammo", "weed_seed").
-   **Icon**: `Sprite` - The UI icon for the item.
-   **Category**: `EItemCategory` - The category this item belongs to (e.g., `Tools`, `Product`).
-   **Keywords**: `string[]` - An array of keywords for searching or filtering.
-   **AvailableInDemo**: `bool` - Whether this item should be available in the demo version of the game.
-   **LabelDisplayColor**: `Color` - The color of the item's name when displayed in certain UI contexts.
-   **StackLimit**: `int` - The maximum number of this item that can be held in a single inventory slot.
-   **Equippable**: `Equippable` - A reference to the prefab that should be instantiated when the player equips this item.
-   **CustomItemUI**: `ItemUI` - A reference to a custom UI prefab for displaying this item in the inventory, if it requires special handling.
-   **CustomInfoContent**: `ItemInfoContent` - A reference to a custom UI prefab for the item's info panel.
-   **legalStatus**: `ELegalStatus` - The legal status of the item, used by the crime system.

## Methods

### GetDefaultInstance
`public virtual ItemInstance GetDefaultInstance(int quantity = 1)`

A virtual method intended to be overridden by all derived classes. It is responsible for creating a new `ItemInstance` of the correct type for this definition. The base implementation logs an error, as it should never be called directly.

-   **Parameters:**
    -   `quantity`: The quantity for the new instance.
-   **Returns:** A new `ItemInstance`, or `null` if not implemented correctly.
