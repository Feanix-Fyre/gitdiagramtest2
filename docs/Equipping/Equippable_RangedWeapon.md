# Equippable_RangedWeapon

Inherits from `Equippable_AvatarViewmodel`.

## Description

A comprehensive class for player-usable ranged weapons. It manages aiming, accuracy, ammunition, firing, reloading, and cocking mechanics, all tied into the first-person avatar viewmodel animations.

## Key Fields & Properties

-   **MagazineSize**: `int` - The capacity of the weapon's magazine.
-   **AimDuration**: `float` - The time it takes to transition into the aiming state.
-   **AimFOVReduction**: `float` - How much the camera's Field of View is reduced when aiming.
-   **FireCooldown**: `float` - The minimum time between shots.
-   **Range**: `float` - The maximum range of the weapon's projectile.
-   **Min/Max Spread**: `float` - The minimum and maximum projectile spread angle (in degrees), determined by accuracy.
-   **Damage**: `float` - The damage dealt by a single shot.
-   **CanReload**: `bool` - Can this weapon be reloaded?
-   **IncrementalReload**: `bool` - If true, the weapon is reloaded one bullet at a time. If false, the entire magazine is reloaded at once.
-   **Magazine**: `StorableItemDefinition` - The item definition for the ammunition magazine.
-   **MustBeCocked**: `bool` - Does this weapon need to be cocked before it can fire the first shot?
-   **Aim**: `float` (read-only) - The current aim value (0 for not aiming, 1 for fully aimed).
-   **Accuracy**: `float` (read-only) - The current accuracy value (0 for least accurate, 1 for most accurate).
-   **IsReloading**: `bool` (read-only) - Is the weapon currently in the reloading state?
-   **IsCocking**: `bool` (read-only) - Is the weapon currently in the cocking state?
-   **Ammo**: `int` (read-only) - The current amount of ammunition in the weapon.

## Core Logic

-   **Aiming (`UpdateInput`)**:
    -   When the player holds the secondary mouse button, `Aim` smoothly increases to 1. This triggers an FOV override and blocks sprinting.
    -   `Accuracy` also increases towards 1 while aiming and standing still. Moving reduces the maximum possible accuracy.
    -   When the button is released, `Aim` and `Accuracy` decrease.

-   **Firing (`UpdateInput` -> `Fire`)**:
    -   A primary mouse click calls `Fire()` if `CanFire()` returns true.
    -   `Fire()` resets the `TimeSinceFire` cooldown, plays sounds and animations, and consumes one ammo.
    -   It calculates a random spread based on the current `Accuracy` and performs a `SphereCastAll` to detect hits.
    -   It creates an `Impact` object and sends it to the first valid `IDamageable` object that was hit.
    -   It also creates a cosmetic bullet trail effect.

-   **Reloading (`UpdateInput` -> `Reload`)**:
    -   Pressing the reload key calls `Reload()` if `IsReloadReady()` returns true.
    -   The `ReloadRoutine` coroutine is started.
    -   If `IncrementalReload` is true, it reloads one bullet at a time, consuming ammo from the magazine item in the inventory.
    -   If false, it reloads the entire weapon at once.
    -   It plays various animations and events (`onReloadStart`, `onReloadIndividual`, `onReloadEnd`) throughout the process.

-   **Cocking (`UpdateInput` -> `Cock`)**:
    -   If `MustBeCocked` is true and the weapon is not yet cocked, the first primary click will call `Cock()` instead of `Fire()`.
    -   This plays a cocking animation and sets the `IsCocked` flag to true after a delay, allowing the weapon to be fired on the next click.

## Public Methods

### Fire
`public virtual void Fire()`

The main method for firing the weapon, handling all associated effects and logic.

### Reload
`public virtual void Reload()`

Initiates the reloading process by starting the `ReloadRoutine` coroutine.
