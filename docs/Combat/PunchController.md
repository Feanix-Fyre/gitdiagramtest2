# PunchController

Inherits from `MonoBehaviour`.

## Description

This class, attached to a `Player`, manages the logic for performing unarmed punches. It handles charging up a punch by holding the attack button, consuming stamina, and then releasing the punch to deal damage and apply force to objects in front of the player.

## Key Constants

-   **MAX_PUNCH_LOAD**: `1f` - The time in seconds to fully charge a punch.
-   **PUNCH_RANGE**: `1.25f` - The maximum distance of the punch attack.

## Fields

-   **Min/Max PunchDamage**: `float` - The damage dealt by a non-charged vs. fully-charged punch.
-   **Min/Max PunchForce**: `float` - The physics force applied by a non-charged vs. fully-charged punch.
-   **Min/Max StaminaCost**: `float` - The stamina consumed by a non-charged vs. fully-charged punch.
-   **PunchSound**: `AudioSourceController` - The sound effect for a punch.
-   **PunchAnimator**: `RuntimeAnimatorController` - The animator controller for the punching viewmodel.

## Properties

-   **PunchingEnabled**: `bool` - Can the player currently punch? This is disabled when UI is open, an item is equipped, etc.
-   **IsLoading**: `bool` (read-only) - Is the player currently holding the primary click to charge a punch?
-   **IsPunching**: `bool` (read-only) - Is the punch animation/attack coroutine currently active?

## Core Logic

1.  **Check for Enabled State**: The `Update` loop first calls `ShouldBeEnabled()` to determine if punching should be possible (e.g., no item equipped, no UI open, not in a vehicle).
2.  **Input Handling (`UpdateInput`)**:
    -   When the player presses the primary mouse button, `StartLoad()` is called. This makes the viewmodel avatar visible and begins draining stamina.
    -   As long as the button is held, `punchLoad` increases, and stamina is drained proportionally. The "Load" parameter is updated on the viewmodel and camera animators.
    -   If the player runs out of stamina, the punch is automatically released.
    -   When the player releases the button, `Release()` is called.
3.  **Release and Punch**:
    -   `Release()` calls `Punch()` with a power value from 0.0 to 1.0 based on how long the punch was charged.
    -   `Punch()` starts a coroutine that plays the punch sound and animation.
    -   After a short delay (`0.1f` seconds), `ExecuteHit()` is called.
4.  **Hit Detection (`ExecuteHit`)**:
    -   `ExecuteHit` performs a raycast in front of the player.
    -   If an `IDamageable` object is hit, it creates an `Impact` object with damage and force scaled by the punch `power`.
    -   It sends this `Impact` to the `IDamageable` object and triggers visual/audio feedback (impact FX, camera shake).
5.  **Cooldown**: After the punch is complete, a short `remainingCooldown` is applied, preventing the player from immediately starting another punch. The cooldown duration is also scaled by the punch power.
