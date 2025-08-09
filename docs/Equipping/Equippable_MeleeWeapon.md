# Equippable_MeleeWeapon

Inherits from `Equippable_AvatarViewmodel`.

## Description

This class provides the logic for a generic, player-usable melee weapon. It's very similar in concept to the `PunchController` but for an equipped item. It handles charging up an attack, consuming stamina, and dealing damage in a cone in front of the player.

## Fields

-   **ImpactType**: `EImpactType` - The type of impact this weapon deals (e.g., `BluntMetal`, `SharpMetal`).
-   **Range**: `float` - The maximum range of the melee attack.
-   **HitRadius**: `float` - The radius of the attack, used for a sphere-cast-like check.
-   **Min/Max LoadTime**: `float` - The time it takes to fully charge an attack.
-   **Min/Max Cooldown**: `float` - The cooldown duration after an attack, scaled by the charge power.
-   **Min/Max HitDelay**: `float` - The delay between starting the swing and the damage being applied, scaled by charge power.
-   **Min/Max Damage**: `float` - The damage dealt by a non-charged vs. fully-charged attack.
-   **Min/Max Force**: `float` - The physics force applied by a non-charged vs. fully-charged attack.
-   **Min/Max StaminaCost**: `float` - The stamina consumed by a non-charged vs. fully-charged attack.
-   **WhooshSound / ImpactSound**: `AudioSourceController` - Sound effects for the swing and for hitting a target.
-   **SwingAnimationTrigger**: `string` - An optional animation trigger to play on the full-body player avatar when swinging.

## Properties

-   **IsLoading**: `bool` (read-only) - Is the player currently holding the primary click to charge an attack?
-   **IsAttacking**: `bool` (read-only) - Is the attack/swing animation coroutine currently active?

## Core Logic

The logic flow is nearly identical to `PunchController`:
1.  **Check for Enabled State (`CanStartLoading`)**: The `Update` loop checks if an attack can be initiated (not on cooldown, has enough stamina, equip animation is finished).
2.  **Input Handling (`UpdateInput`)**:
    -   When the player presses the primary mouse button, `StartLoad()` is called, which begins draining stamina.
    -   As long as the button is held, `load` increases, and stamina is drained. The "Load" parameter is updated on the viewmodel and camera animators.
    -   When the player releases the button, `Release()` is called.
3.  **Release and Hit**:
    -   `Release()` calls `Hit()` with a power value from 0.0 to 1.0 based on the charge time.
    -   `Hit()` starts a coroutine that plays the whoosh sound and the viewmodel swing animation.
    -   After a delay (`HitDelay`), `ExecuteHit()` is called.
4.  **Hit Detection (`ExecuteHit`)**:
    -   `ExecuteHit` performs a sphere-cast (`LookRaycast` with a radius) in front of the player.
    -   If an `IDamageable` object is hit, it creates an `Impact` object with damage and force scaled by the attack `power`.
    -   It sends this `Impact` to the `IDamageable` object and triggers visual/audio feedback (impact sound, impact FX, camera shake).
5.  **Cooldown**: After the attack, a `remainingCooldown` is applied, scaled by the attack power.
