# MapHeightSampler

The `MapHeightSampler` class is a static utility class that provides methods for sampling the height of the map.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ResetPosition` | `Vector3` | The position to reset to if the height cannot be sampled. |

## Methods

### `Sample(float x, out float y, float z)`

Samples the height of the map at a given position.

**Parameters:**

* `x`: The x-coordinate of the position to sample.
* `y`: Returns the height of the map at the given position.
* `z`: The z-coordinate of the position to sample.

**Returns:** `bool`
