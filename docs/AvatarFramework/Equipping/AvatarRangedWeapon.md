# AvatarRangedWeapon

Inherits from `AvatarWeapon`.

## Description

A base class for ranged weapons that can be equipped by an avatar. It manages ammunition, reloading, fire rate, and the state of the weapon (e.g., raised or lowered).

## Fields

-   **RaycastLayers**: `static string[]`
    -   A list of layer names that the weapon's line-of-sight checks will collide with.
-   **MagazineSize**: `int`
    -   The number of shots the weapon can fire before reloading. -1 for infinite ammo.
-   **ReloadTime**: `float`
    -   The time in seconds it takes to reload the weapon.
-   **MaxFireRate**: `float`
    -   The minimum time in seconds between shots.
-   **CanShootWhileMoving**: `bool`
    -   Whether the avatar can shoot this weapon while moving.
-   **EquipTime**: `float`
    -   The time in seconds after equipping before the weapon can be fired.
-   **RaiseTime**: `float`
    -   The time in seconds after raising the weapon before it can be fired.
-   **Damage**: `float`
    -   The base damage dealt by the weapon.
-   **HitChange_MinRange**: `float`
    -   The probability of hitting a target at minimum range (likely a typo for HitChance).
-   **HitChange_MaxRange**: `float`
    -   The probability of hitting a target at maximum range (likely a typo for HitChance).
-   **MuzzlePoint**: `Transform`
    -   The transform from which shots are fired.
-   **FireSound**: `AudioSourceController`
    -   The audio source for firing sounds.
-   **LoweredAnimationTrigger**: `string`
    -   The animation trigger for lowering the weapon.
-   **RaisedAnimationTrigger**: `string`
    -   The animation trigger for raising the weapon.
-   **RecoilAnimationTrigger**: `string`
    -   The animation trigger for the firing recoil.
-   **IsRaised**: `bool` (read-only)
    -   Is the weapon currently in the raised/aiming position?

## Methods

### SetIsRaised
`public virtual void SetIsRaised(bool raised)`

Sets the weapon's state to raised or lowered and plays the corresponding animation.

-   **Parameters:**
    -   `raised`: True to raise the weapon, false to lower it.

### ReceiveMessage
`public override void ReceiveMessage(string message, object data)`

Handles incoming messages. It responds to "Shoot", "Lower", and "Raise" messages.

### CanShoot
`public bool CanShoot()`

Checks if the weapon is currently able to fire based on ammo, reload status, and various timers (`timeEquipped`, `timeSinceLastShot`, `timeRaised`).

-   **Returns:** True if the weapon can be fired, otherwise false.

### Shoot
`public virtual void Shoot(Vector3 endPoint)`

Fires the weapon. This method is typically called via `ReceiveMessage`. It handles ammo consumption, playing sounds, triggering recoil animations, and initiating the reload coroutine if the magazine is empty.

-   **Parameters:**
    -   `endPoint`: The target position of the shot.

### IsPlayerInLoS
`public bool IsPlayerInLoS(Player target)`

Performs a raycast from the muzzle to a target player to check for a clear line of sight.

-   **Parameters:**
    -   `target`: The player to check line of sight against.
-   **Returns:** True if there is a clear line of sight to the target, otherwise false.
