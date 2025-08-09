# Equippable_AvatarViewmodel

Inherits from `Equippable_Viewmodel`.

## Description

This class extends `Equippable_Viewmodel` for items that require the full first-person avatar viewmodel (arms and hands) to be visible and animated. It handles setting the animator controller on the `ViewmodelAvatar` and triggering equip animations.

## Fields

-   **AnimatorController**: `RuntimeAnimatorController`
    -   The animator controller that should be used for the player's arms when this item is equipped.
-   **ViewmodelAvatarOffset**: `Vector3`
    -   An offset applied to the viewmodel avatar, allowing for fine-tuned positioning of the hands/arms for this specific item.
-   **EquipTime**: `float`
    -   The duration of the equip animation.
-   **EquipTrigger**: `string`
    -   The name of the trigger parameter in the `AnimatorController` to play the equip animation.

## Properties

-   **equipAnimDone**: `protected bool` (read-only)
    -   Returns true if the time since equipping is greater than `EquipTime`.

## Methods

### Equip
`public override void Equip(ItemInstance item)`

Overrides the base `Equip` method. It parents the item to the `ViewmodelAvatar`'s right hand container and then configures the `ViewmodelAvatar`:
-   Sets its `AnimatorController`.
-   Makes it visible.
-   Applies the `ViewmodelAvatarOffset`.

### Unequip
`public override void Unequip()`

Overrides the base `Unequip` method to hide the `ViewmodelAvatar` when the item is unequipped.

### PlayEquipAnimation
`protected override void PlayEquipAnimation()`

Overrides the base method to play the equip animation by setting the `EquipTrigger` on the `ViewmodelAvatar`'s animator.
