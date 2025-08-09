# Taser

Inherits from `AvatarRangedWeapon`.

## Description

Represents a taser weapon. It extends `AvatarRangedWeapon` to include taser-specific logic and effects, such as a charging sound when raised and a flash/ray effect when fired.

## Constants

-   **TaseDuration**: `float` - The duration of the tase effect (2 seconds).
-   **TaseMoveSpeedMultiplier**: `float` - The movement speed multiplier applied to a tased character (0.5).

## Fields

-   **FlashObject**: `GameObject`
    -   The game object for the muzzle flash effect.
-   **ChargeSound**: `AudioSourceController`
    -   The audio source for the sound that plays while the taser is raised and charging.
-   **RayPrefab**: `GameObject`
    -   A prefab used to visualize the taser's electric arc.

## Methods

### Equip
`public override void Equip(Avatar _avatar)`

Overrides the base `Equip` method to ensure the `FlashObject` is initially inactive.

-   **Parameters:**
    -   `_avatar`: The avatar equipping the taser.

### Shoot
`public override void Shoot(Vector3 endPoint)`

Overrides the base `Shoot` method. It stops the charging sound and starts the `Flash` coroutine to create the firing visual effect.

-   **Parameters:**
    -   `endPoint`: The target position of the shot.

### SetIsRaised
`public override void SetIsRaised(bool raised)`

Overrides the base `SetIsRaised` method to play the `ChargeSound` when the taser is raised and stop it when it's lowered.

-   **Parameters:**
    -   `raised`: True to raise the taser, false to lower it.

### Flash
`private IEnumerator Flash(Vector3 endPoint)`

A coroutine that creates the taser's visual effect. It activates the `FlashObject` and instantiates the `RayPrefab`, scaling and positioning it to look like an electric arc between the muzzle and the `endPoint`. The effect lasts for 0.2 seconds.

-   **Parameters:**
    -   `endPoint`: The target position of the shot.
