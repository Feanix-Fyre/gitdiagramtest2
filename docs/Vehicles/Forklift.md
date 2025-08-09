# Forklift

The `Forklift` class inherits from `LandVehicle` and represents a forklift. It has additional functionality for controlling the forklift's forks, including raising and lowering them. It also has a reference to a steering wheel, which is animated based on the steering angle.

## Protected Properties

| Property                       | Type        | Description                                      |
| ------------------------------ | ----------- | ------------------------------------------------ |
| `steeringWheel`                | `Transform` | The transform of the steering wheel.               |
| `forkRb`                       | `Rigidbody` | The rigidbody of the forks.                      |
| `joint`                        | `ConfigurableJoint` | The configurable joint for the forks.            |
| `steeringWheelAngleMultiplier` | `float`     | A multiplier for the steering wheel's angle.     |
| `lift_MinY`                    | `float`     | The minimum height of the forks.                 |
| `lift_MaxY`                    | `float`     | The maximum height of the forks.                 |
| `liftMoveRate`                 | `float`     | The rate at which the forks move.                |

## Public Properties

| Property           | Type    | Description                                      |
| ------------------ | ------- | ------------------------------------------------ |
| `targetForkHeight` | `float` | The target height of the forks, from 0 to 1.     |
| `actualForkHeight` | `float` | The actual height of the forks, from 0 to 1.     |

## Protected Methods

| Method       | Return Type | Description             |
| ------------ | ----------- | ----------------------- |
| `Update()`     | `void`      | Updates the forklift.   |
| `FixedUpdate()`| `void`      | Updates the forklift's physics. |
| `LateUpdate()` | `void`      | Updates the forklift after all other updates. |
