# BoilingFlask

The `BoilingFlask` class represents a boiling flask. It inherits from the `Fillable` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `LockTemperature` | `bool` | If `true`, the temperature of the flask will be locked. |
| `BoilSoundPitchCurve` | `AnimationCurve` | The pitch curve for the boil sound. |
| `LabelJitterScale` | `float` | The scale of the label jitter. |
| `Burner` | `BunsenBurner` | The bunsen burner that is heating the flask. |
| `TemperatureCanvas` | `Canvas` | The canvas for the temperature UI. |
| `TemperatureLabel` | `TextMeshProUGUI` | The label for the temperature. |
| `TemperatureSlider` | `Slider` | The slider for the temperature. |
| `TemperatureRangeIndicator` | `RectTransform` | The indicator for the temperature range. |
| `SmokeParticles` | `ParticleSystem` | The particle system for the smoke. |
| `BoilSound` | `AudioSourceController` | The audio source for the boil sound. |
| `OverheatMesh` | `MeshRenderer` | The mesh for the overheat effect. |
| `CurrentTemperature` | `float` | The current temperature of the flask. |
| `CurrentTemperatureVelocity` | `float` | The current temperature velocity of the flask. |
| `IsTemperatureInRange` | `bool` | Returns `true` if the temperature is in the range for the current recipe. |
| `OverheatScale` | `float` | The scale of the overheat effect. |
| `Recipe` | `StationRecipe` | The current recipe. |

## Methods

### `SetCanvasVisible(bool visible)`

Sets the visibility of the temperature canvas.

**Parameters:**

* `visible`: If `true`, the canvas will be visible.

### `SetTemperature(float temp)`

Sets the temperature of the flask.

**Parameters:**

* `temp`: The temperature to set.

### `SetRecipe(StationRecipe recipe)`

Sets the recipe for the flask.

**Parameters:**

* `recipe`: The recipe to set.
