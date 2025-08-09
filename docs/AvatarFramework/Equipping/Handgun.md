# Handgun

Inherits from `AvatarRangedWeapon`.

## Description

A specific implementation of `AvatarRangedWeapon` for a handgun. It adds visual effects for firing, such as a muzzle flash, particle effects for smoke and ejected shells, and a projectile ray visualization.

## Fields

-   **Anim**: `UnityEngine.Animation`
    -   A reference to the `Animation` component on the handgun model, used for firing animations (e.g., slide moving back).
-   **ShellParticles**: `ParticleSystem`
    -   Particle system for ejecting shell casings.
-   **SmokeParticles**: `ParticleSystem`
    -   Particle system for muzzle smoke.
-   **FlashObject**: `Transform`
    -   The transform of the muzzle flash game object.
-   **RayPrefab**: `GameObject`
    -   A prefab used to visualize the bullet's trajectory as a ray.

## Methods

### Shoot
`public override void Shoot(Vector3 endPoint)`

Overrides the base `Shoot` method to add handgun-specific effects. It plays the handgun's animation, emits particles for the shell and smoke, and starts a `Flash` coroutine to handle the muzzle flash and projectile ray visualization.

-   **Parameters:**
    -   `endPoint`: The target position of the shot.

### Flash
`private IEnumerator Flash(Vector3 endPoint)`

A coroutine that creates the muzzle flash and a visual representation of the bullet's path. It activates the `FlashObject` with a random rotation and instantiates the `RayPrefab`, scaling and rotating it to stretch from the muzzle to the `endPoint`. Both effects last for a very short duration.

-   **Parameters:**
    -   `endPoint`: The target position of the shot.
