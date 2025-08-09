# VehicleCamera

The `VehicleCamera` class controls the camera when the player is in a vehicle. It provides a third-person view of the vehicle and allows the player to orbit the camera around the vehicle. It also handles camera collisions to prevent the camera from going through walls.

## Public Properties

| Property | Type        | Description                                      |
| -------- | ----------- | ------------------------------------------------ |
| `vehicle`  | `LandVehicle` | The `LandVehicle` that this component is attached to. |

## Protected Properties

| Property                  | Type        | Description                                      |
| ------------------------- | ----------- | ------------------------------------------------ |
| `cameraOrigin`            | `Transform` | The point the camera will orbit around.          |
| `lateralOffset`           | `float`     | The lateral offset of the camera from the vehicle. |
| `verticalOffset`          | `float`     | The vertical offset of the camera from the vehicle.|
| `cameraReversed`          | `bool`      | A boolean that indicates whether the camera is reversed. |
| `timeSinceCameraManuallyAdjusted` | `float` | The time since the camera was last manually adjusted. |
| `orbitDistance`           | `float`     | The distance of the camera from the vehicle.     |
| `lastFrameCameraOffset`   | `Vector3`   | The camera offset from the last frame.           |
| `lastManualOffset`        | `Vector3`   | The last manual camera offset.                   |

## Protected Methods

| Method       | Return Type | Description             |
| ------------ | ----------- | ----------------------- |
| `Start()`      | `void`      | Initializes the camera. |
| `Update()`     | `void`      | Updates the camera.     |
| `LateUpdate()` | `void`      | Updates the camera after all other updates. |
