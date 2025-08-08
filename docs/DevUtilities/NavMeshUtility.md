# NavMeshUtility

The `NavMeshUtility` class is a static utility class that provides methods for working with the NavMesh system.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `SampleCache` | `Dictionary<Vector3, Vector3>` | A cache of sampled positions. |
| `sampleCacheKeys` | `List<Vector3>` | A list of keys for the sample cache. |

## Methods

### `GetPathLength(NavMeshPath path)`

Gets the length of a NavMesh path.

**Parameters:**

* `path`: The path to get the length of.

**Returns:** `float`

### `GetAccessPoint(ITransitEntity entity, NPC npc)`

Gets the access point for a transit entity.

**Parameters:**

* `entity`: The transit entity to get the access point for.
* `npc`: The NPC to get the access point for.

**Returns:** `Transform`

### `IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)`

Returns `true` if an NPC is at a transit entity.

**Parameters:**

* `entity`: The transit entity to check.
* `npc`: The NPC to check.
* `distanceThreshold`: The distance threshold to use when checking if the NPC is at the transit entity.

**Returns:** `bool`

### `GetNavMeshAgentID(string name)`

Gets the ID of a NavMesh agent by its name.

**Parameters:**

* `name`: The name of the NavMesh agent to get the ID of.

**Returns:** `int`

### `SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)`

Samples a position on the NavMesh.

**Parameters:**

* `sourcePosition`: The position to sample.
* `hit`: Returns the NavMesh hit information.
* `maxDistance`: The maximum distance to sample.
* `areaMask`: The area mask to use when sampling.
* `useCache`: If `true`, the sample cache will be used.

**Returns:** `bool`

### `ClearCache()`

Clears the sample cache.
