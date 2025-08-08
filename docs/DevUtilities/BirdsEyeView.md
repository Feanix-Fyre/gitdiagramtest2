# BirdsEyeView

The `BirdsEyeView` class is a singleton that provides a bird's eye view camera for debugging purposes.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `bounds_Min` | `Vector3` | The minimum bounds of the camera. |
| `bounds_Max` | `Vector3` | The maximum bounds of the camera. |
| `lateralMovementSpeed` | `float` | The speed of lateral movement. |
| `scrollMovementSpeed` | `float` | The speed of scroll movement. |
| `targetFollowSpeed` | `float` | The speed at which the camera follows the target. |
| `xSpeed` | `float` | The speed of the camera's x rotation. |
| `ySpeed` | `float` | The speed of the camera's y rotation. |
| `yMinLimit` | `float` | The minimum y angle of the camera. |
| `yMaxLimit` | `float` | The maximum y angle of the camera. |
| `isEnabled` | `bool` | Returns `true` if the bird's eye view is enabled. |

## Methods

### `Enable(Vector3 startPosition, Quaternion startRotation)`

Enables the bird's eye view.

**Parameters:**

* `startPosition`: The starting position of the camera.
* `startRotation`: The starting rotation of the camera.

### `Disable(bool reenableCameraLook = true)`

Disables the bird's eye view.

**Parameters:**

* `reenableCameraLook`: If `true`, the camera look will be re-enabled.

### `SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)`

Slides the camera origin to a new position.

**Parameters:**

* `position`: The new position of the camera origin.
* `offsetDistance`: The offset distance from the new position.
* `time`: The time to slide the camera origin over.
