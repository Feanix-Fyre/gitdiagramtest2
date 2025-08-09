# CameraOrbit

The `CameraOrbit` class is a component that provides an orbit camera for debugging purposes.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `target` | `Transform` | The target to orbit around. |
| `cam` | `Transform` | The camera to control. |
| `raycaster` | `GraphicRaycaster` | The graphic raycaster to use for UI interaction. |
| `LookAt` | `AvatarLookController` | The look at controller to use for the avatar. |
| `targetdistance` | `float` | The target distance from the target. |
| `xSpeed` | `float` | The speed of the camera's x rotation. |
| `ySpeed` | `float` | The speed of the camera's y rotation. |
| `sideOffset` | `float` | The side offset of the camera. |
| `yMinLimit` | `float` | The minimum y angle of the camera. |
| `yMaxLimit` | `float` | The maximum y angle of the camera. |
| `distanceMin` | `float` | The minimum distance from the target. |
| `distanceMax` | `float` | The maximum distance from the target. |
| `ScrollSensativity` | `float` | The sensitivity of the scroll wheel. |

## Methods

### `ClampAngle(float angle, float min, float max)`

Clamps an angle between a min and max value.

**Parameters:**

* `angle`: The angle to clamp.
* `min`: The minimum value.
* `max`: The maximum value.

**Returns:** `float`
