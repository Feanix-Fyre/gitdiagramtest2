# PostProcessingManager

The `PostProcessingManager` class is a singleton that manages post-processing effects.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `GlobalVolume` | `Volume` | The global volume. |
| `Vig_DefaultIntensity` | `float` | The default intensity of the vignette. |
| `Vig_DefaultSmoothness` | `float` | The default smoothness of the vignette. |
| `MinBlur` | `float` | The minimum blur intensity. |
| `MaxBlur` | `float` | The maximum blur intensity. |
| `ChromaticAberrationController` | `FloatSmoother` | The controller for the chromatic aberration. |
| `SaturationController` | `FloatSmoother` | The controller for the saturation. |
| `BloomController` | `FloatSmoother` | The controller for the bloom. |
| `ColorFilterController` | `HDRColorSmoother` | The controller for the color filter. |

## Methods

### `OverrideVignette(float intensity, float smoothness)`

Overrides the vignette.

**Parameters:**

* `intensity`: The intensity of the vignette.
* `smoothness`: The smoothness of the vignette.

### `ResetVignette()`

Resets the vignette to its default values.

### `SetGodRayIntensity(float intensity)`

Sets the intensity of the god rays.

**Parameters:**

* `intensity`: The intensity to set.

### `SetContrast(float value)`

Sets the contrast.

**Parameters:**

* `value`: The value to set.

### `SetSaturation(float value)`

Sets the saturation.

**Parameters:**

* `value`: The value to set.

### `SetBloomThreshold(float threshold)`

Sets the bloom threshold.

**Parameters:**

* `threshold`: The threshold to set.

### `SetBlur(float blurLevel)`

Sets the blur level.

**Parameters:**

* `blurLevel`: The blur level to set.
