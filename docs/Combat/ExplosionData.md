# ExplosionData

A struct that holds the parameters for an explosion.

## Description

This data structure is used to define the properties of an explosion, such as its size and power. It is passed to the `CombatManager` when creating an explosion.

## Fields

-   **DamageRadius**: `float`
    -   The radius within which the explosion deals damage.
-   **MaxDamage**: `float`
    -   The maximum damage dealt at the epicenter of the explosion. Damage falls off linearly to zero at the edge of the `DamageRadius`.
-   **PushForceRadius**: `float`
    -   The radius within which the explosion applies a physics force to objects.
-   **MaxPushForce**: `float`
    -   The maximum push force applied at the epicenter. Force falls off linearly to zero at the edge of the `PushForceRadius`.

## Static Fields

-   **DefaultSmall**: `static readonly ExplosionData`
    -   A predefined instance for a small explosion.

## Constructors

### ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
Creates a new `ExplosionData` instance. The `PushForceRadius` is automatically set to be twice the `damageRadius`.

-   **Parameters:**
    -   `damageRadius`: The radius for damage.
    -   `maxDamage`: The maximum damage.
    -   `maxPushForce`: The maximum physics push force.
