# ForkliftCamera

The `ForkliftCamera` class inherits from `VehicleCamera` and provides a specific camera for the forklift. It has a special "fork cam" that is activated when the player holds down the left shift key. This camera provides a better view of the forks.

## Protected Properties

| Property         | Type        | Description                                      |
| ---------------- | ----------- | ------------------------------------------------ |
| `forkCamPos`     | `Transform` | The transform of the fork camera.                |
| `guidanceLight`  | `Light`     | The guidance light for the fork camera.          |
| `forkliftCamActive` | `bool`      | A boolean that indicates whether the fork camera is active. |

## Protected Methods

| Method       | Return Type | Description             |
| ------------ | ----------- | ----------------------- |
| `Update()`     | `void`      | Updates the camera.     |
| `LateUpdate()` | `void`      | Updates the camera after all other updates. |
