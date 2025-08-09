# LightOptimizer

The `LightOptimizer` class is a component that optimizes lights by disabling them when they are not visible to the player.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `LightsEnabled` | `bool` | If `true`, the lights will be enabled. |
| `checkRange` | `float` | The range at which to check if the lights are visible. |

## Methods

### `ApplyLights()`

Applies the lights. This method enables or disables the lights based on whether they are visible to the player.

### `PointInCameraView(Vector3 point)`

Returns `true` if a point is in the camera's view.

**Parameters:**

* `point`: The point to check.

**Returns:** `bool`

### `Is01(float a)`

Returns `true` if a float is between 0 and 1.

**Parameters:**

* `a`: The float to check.

**Returns:** `bool`

### `LightsEnabled_True()`

Enables the lights.

### `LightsEnabled_False()`

Disables the lights.
