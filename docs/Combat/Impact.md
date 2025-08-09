# Impact

A serializable class that encapsulates all the data related to a single combat impact event.

## Description

This class is used to pass information about a hit or an impact between different game systems. For example, when a weapon hits a character, it creates an `Impact` object and sends it to the character's `IDamageable` component.

## Fields

-   **Hit**: `RaycastHit`
    -   The `RaycastHit` information from the physics check that detected the impact. Note: This field is excluded from network serialization.
-   **HitPoint**: `Vector3`
    -   The world-space point where the impact occurred.
-   **ImpactForceDirection**: `Vector3`
    -   A normalized vector representing the direction of the force.
-   **ImpactForce**: `float`
    -   The magnitude of the physics force to be applied.
-   **ImpactDamage**: `float`
    -   The amount of damage to be dealt.
-   **ImpactType**: `EImpactType`
    -   The type of impact (e.g., `Bullet`, `Punch`).
-   **ImpactSource**: `NetworkObject`
    -   A reference to the network object of the player or entity that caused the impact.
-   **ImpactID**: `int`
    -   A unique ID for this impact, used to prevent duplicate processing of the same event.

## Constructors

### Impact(...)
Creates a new `Impact` instance with all fields initialized.

### Impact()
An empty constructor for serialization.

## Methods

### IsLethal
`public static bool IsLethal(EImpactType impactType)`

A static helper method to determine if a given impact type is considered lethal.

-   **Parameters:**
    -   `impactType`: The type of impact to check.
-   **Returns:** `true` if the impact is from `SharpMetal`, `Bullet`, or `Explosion`.

### IsPlayerImpact
`public bool IsPlayerImpact(out Player player)`

Checks if the impact was caused by a player and provides a reference to that player.

-   **Parameters:**
    -   `player`: An `out` parameter that will be populated with the `Player` component of the `ImpactSource` if it exists.
-   **Returns:** `true` if the `ImpactSource` is a player, otherwise `false`.
