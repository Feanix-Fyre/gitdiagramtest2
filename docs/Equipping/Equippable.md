# Equippable

Inherits from `MonoBehaviour`.

## Description

A base class for all items that can be equipped by the player. When an item from the player's inventory is "used", its corresponding `Equippable` prefab is instantiated. This class provides the fundamental logic for equipping and unequipping.

## Fields

-   **itemInstance**: `protected ItemInstance`
    -   A reference to the `ItemInstance` in the player's inventory that this equipped object represents.
-   **CanInteractWhenEquipped**: `bool`
    -   If true, the player can still interact with other objects while this item is equipped.
-   **CanPickUpWhenEquipped**: `bool`
    -   If true, the player can still pick up items while this item is equipped.

## Methods

### Equip
`public virtual void Equip(ItemInstance item)`

Called by the `PlayerInventory` when the item is equipped. It stores the `itemInstance` and registers itself as the currently equipped item with the `PlayerInventory`.

-   **Parameters:**
    -   `item`: The inventory item instance being equipped.

### Unequip
`public virtual void Unequip()`

Called by the `PlayerInventory` when the item is unequipped. It clears the reference in the `PlayerInventory` and destroys this `Equippable`'s GameObject.
