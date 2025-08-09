# AvatarWeapon

Inherits from `AvatarEquippable`.

## Description

A base class for all weapons that can be equipped by an avatar. It extends `AvatarEquippable` with common weapon properties like range, cooldown, and equip sounds.

## Fields

-   **MinUseRange**: `float`
    -   The minimum range at which the weapon can be used.
-   **MaxUseRange**: `float`
    -   The maximum range at which the weapon can be used.
-   **CooldownDuration**: `float`
    -   The time in seconds before the weapon can be used again after an attack.
-   **EquipClips**: `AudioClip[]`
    -   An array of audio clips that can be played when the weapon is equipped.
-   **EquipSound**: `AudioSourceController`
    -   The audio source used to play the equip sounds.
-   **onSuccessfulHit**: `UnityEvent`
    -   An event that is invoked when the weapon successfully hits a target.
-   **LastUseTime**: `float` (read-only)
    -   The `Time.time` at which the weapon was last used.

## Methods

### Equip
`public override void Equip(Avatar _avatar)`

Overrides the base `Equip` method to add the functionality of playing a random equip sound from the `EquipClips` array.

-   **Parameters:**
    -   `_avatar`: The avatar equipping the weapon.

### Attack
`public virtual void Attack()`

A virtual method intended to be called when the weapon attacks. It updates the `LastUseTime`.

### IsReadyToAttack
`public virtual bool IsReadyToAttack()`

Checks if the weapon's cooldown has finished.

-   **Returns:** True if the time since the last attack is greater than `CooldownDuration`.
