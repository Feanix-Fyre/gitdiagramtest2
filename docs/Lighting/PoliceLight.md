# PoliceLight

The `PoliceLight` class is a component that controls a police light.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `IsOn` | `bool` | If `true`, the light is on. |
| `RedMeshes` | `MeshRenderer[]` | An array of red meshes. |
| `BlueMeshes` | `MeshRenderer[]` | An array of blue meshes. |
| `RedLights` | `OptimizedLight[]` | An array of red lights. |
| `BlueLights` | `OptimizedLight[]` | An array of blue lights. |
| `Siren` | `AudioSourceController` | The siren audio source. |
| `CycleDuration` | `float` | The duration of a cycle. |
| `RedOffMat` | `Material` | The material for the red light when it is off. |
| `RedOnMat` | `Material` | The material for the red light when it is on. |
| `BlueOffMat` | `Material` | The material for the blue light when it is off. |
| `BlueOnMat` | `Material` | The material for the blue light when it is on. |
| `RedBrightnessCurve` | `AnimationCurve` | The brightness curve for the red light. |
| `BlueBrightnessCurve` | `AnimationCurve` | The brightness curve for the blue light. |
| `LightBrightness` | `float` | The brightness of the light. |

## Methods

### `SetIsOn(bool isOn)`

Sets whether the light is on.

**Parameters:**

* `isOn`: If `true`, the light is on.
