# Explosion

Inherits from `MonoBehaviour`.

## Description

This class represents an explosion event. When initialized, it plays a sound, emits a noise event for AI detection, and applies damage and physics forces to all `IDamageable` objects within its radius.

## Fields

-   **Sound**: `AudioSourceController`
    -   The audio source for the explosion sound effect.

## Methods

### Initialize
`public void Initialize(Vector3 origin, ExplosionData data)`

This is the main method that triggers the explosion's logic. It is called by the `CombatManager` when an explosion is instantiated.

The method performs the following actions:
1.  Sets the explosion's position to `origin`.
2.  Plays the `Sound`.
3.  Emits a `NoiseEvent` of type `Explosion` to alert nearby NPCs.
4.  **On the server only**:
    a.  Performs an `OverlapSphere` check to find all colliders within the explosion's maximum radius.
    b.  For each unique `IDamageable` object found, it performs a `Raycast` from the explosion's origin to the object to check for line of sight. This ensures objects behind cover are not affected.
    c.  If there is a clear line of sight, it calculates the damage and push force based on the object's distance from the origin, using a linear falloff.
    d.  It creates a new `Impact` data structure and sends it to the `IDamageable` object by calling its `ReceiveImpact` method.

-   **Parameters:**
    -   `origin`: The world-space position where the explosion occurs.
    -   `data`: An `ExplosionData` object containing the parameters for the explosion (e.g., radius, damage, force).
