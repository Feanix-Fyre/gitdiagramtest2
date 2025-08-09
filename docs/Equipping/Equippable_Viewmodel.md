# Equippable_Viewmodel

Inherits from `Equippable_StorableItem`.

## Description

A base class for equippable items that have a first-person "viewmodel" (the model of the item seen in the player's hands). It handles setting the position, rotation, and scale of the viewmodel, as well as configuring its rendering properties and synchronizing the third-person equivalent model.

## Fields

-   **localPosition**: `Vector3`
    -   The local position the viewmodel should have relative to its parent (usually the player's camera or hand).
-   **localEulerAngles**: `Vector3`
    -   The local rotation the viewmodel should have.
-   **localScale**: `Vector3`
    -   The local scale the viewmodel should have.
-   **AvatarEquippable**: `AvatarEquippable`
    -   A reference to the prefab that represents the third-person version of this item, which is equipped on the player's full-body avatar for other players to see.

## Methods

### Equip
`public override void Equip(ItemInstance item)`

Overrides the base `Equip` method. It performs the following setup for the viewmodel:
1.  Sets the local position, rotation, and scale of the viewmodel's transform.
2.  Recursively sets the layer of the viewmodel and its children to the "Viewmodel" layer, which ensures it is only rendered by the first-person camera.
3.  Disables shadow casting for all `MeshRenderer`s on the viewmodel to prevent self-shadowing issues.
4.  Calls `PlayEquipAnimation()`.

### Unequip
`public override void Unequip()`

Overrides the base `Unequip` method to call `PlayUnequipAnimation()`.

### PlayEquipAnimation
`protected virtual void PlayEquipAnimation()`

Handles the third-person model. If an `AvatarEquippable` is assigned, it sends a network message to tell the player's full-body avatar to equip the corresponding third-person model.

### PlayUnequipAnimation
`protected virtual void PlayUnequipAnimation()`

Handles the third-person model. If an `AvatarEquippable` was assigned, it sends a network message to tell the player's full-body avatar to unequip its current item.
