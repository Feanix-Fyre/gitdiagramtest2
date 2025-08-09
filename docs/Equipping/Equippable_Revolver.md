# Equippable_Revolver

Inherits from `Equippable_RangedWeapon`.

## Description

This class represents a specific type of ranged weapon: a revolver. It extends `Equippable_RangedWeapon` to add logic for visually displaying the bullets in the cylinder.

## Fields

-   **Bullets**: `Transform[]`
    -   An array of transforms, each representing a bullet model in the revolver's cylinder.

## Methods

### Equip, Fire, Reload, NotifyIncrementalReload
`public override void Equip(ItemInstance item)`
`public override void Fire()`
`public override void Reload()`
`protected override void NotifyIncrementalReload()`

These methods all override their base class counterparts. After calling the base method, each one calls `SetDisplayedBullets` to ensure the number of visible bullet models in the cylinder matches the current ammunition count.

### SetDisplayedBullets
`private void SetDisplayedBullets(int count)`

Updates the visibility of the bullet models in the `Bullets` array. It iterates through the array and activates the GameObjects for bullets that should be present and deactivates the others.

-   **Parameters:**
    -   `count`: The number of bullets currently in the weapon.
