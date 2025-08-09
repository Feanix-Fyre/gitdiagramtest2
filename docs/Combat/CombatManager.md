# CombatManager

Inherits from `NetworkSingleton<CombatManager>`.

## Description

A singleton manager responsible for handling combat-related events that need to be synchronized across the network, with a primary focus on creating explosions.

## Fields

-   **MeleeLayerMask**: `LayerMask` - A layer mask for melee combat calculations.
-   **ExplosionLayerMask**: `LayerMask` - A layer mask used for determining the location of explosions.
-   **RangedWeaponLayerMask**: `LayerMask` - A layer mask for ranged weapon calculations.
-   **ExplosionPrefab**: `Explosion` - The prefab to instantiate when an explosion is created.

## Methods

### CreateTestExplosion
`public void CreateTestExplosion()`

A debug method callable from a button in the Inspector. It creates a test explosion 10 units in front of the player's camera, or at the point the camera is looking at if it hits something.

### CreateExplosion
`public void CreateExplosion(Vector3 origin, ExplosionData data)`

The main public method for creating an explosion. It generates a random ID for the explosion and then calls a `ServerRpc` to initiate the explosion creation on the server, which then broadcasts it to all clients.

-   **Parameters:**
    -   `origin`: The world-space position where the explosion should occur.
    -   `data`: An `ExplosionData` object containing the parameters for the explosion (e.g., radius, damage).

### CreateExplosion (ServerRpc)
`private void CreateExplosion(Vector3 origin, ExplosionData data, int id)`

A `ServerRpc` that is called by clients. It simply calls the `Explosion` `ObserversRpc` to ensure the event is broadcast to all clients (including the server).

### Explosion (ObserversRpc)
`private void Explosion(Vector3 origin, ExplosionData data, int id)`

An `ObserversRpc` that is called on all clients. It checks if the explosion `id` has already been processed to prevent duplicates, then instantiates the `ExplosionPrefab`, initializes it with the provided data, and schedules it for destruction after 3 seconds.
