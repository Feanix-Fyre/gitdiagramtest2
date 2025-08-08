# OptimizedLight

The `OptimizedLight` class is a component that optimizes lights by disabling them when they are not visible to the player.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Enabled` | `bool` | If `true`, the light will be enabled. |
| `DisabledForOptimization` | `bool` | If `true`, the light is disabled for optimization. |
| `MaxDistance` | `float` | The maximum distance at which the light is visible. |
| `_Light` | `Light` | The light component. |

## Methods

### `SetEnabled(bool enabled)`

Sets whether the light is enabled.

**Parameters:**

* `enabled`: If `true`, the light will be enabled.
