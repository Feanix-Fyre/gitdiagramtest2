# FXManager

The `FXManager` class is a singleton that manages visual effects.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `PunchImpactsClips` | `AudioClip[]` | An array of audio clips for punch impacts. |
| `SlashImpactClips` | `AudioClip[]` | An array of audio clips for slash impacts. |
| `ImpactSources` | `AudioSourceController[]` | An array of audio source controllers for impacts. |
| `PunchParticlePrefab` | `GameObject` | The prefab for the punch particle effect. |
| `BulletTrail` | `TrailRenderer` | The trail renderer for bullet trails. |

## Methods

### `CreateImpactFX(Impact impact)`

Creates an impact effect.

**Parameters:**

* `impact`: The impact to create the effect for.

### `CreateBulletTrail(Vector3 start, Vector3 dir, float speed, float range, LayerMask mask)`

Creates a bullet trail.

**Parameters:**

* `start`: The start position of the trail.
* `dir`: The direction of the trail.
* `speed`: The speed of the trail.
* `range`: The range of the trail.
* `mask`: The layer mask to use for collision detection.
