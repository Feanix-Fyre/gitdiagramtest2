# VehicleObstacle

The `VehicleObstacle` class represents an obstacle that can be detected by a `VehicleAgent`.

## Enums

### EObstacleType

This enum defines the different types of obstacles.

-   `Generic`: A generic obstacle.
-   `TrafficLight`: A traffic light.

## Public Properties

| Property   | Type          | Description                                      |
| ---------- | ------------- | ------------------------------------------------ |
| `col`      | `Collider`    | The collider that defines the bounds of the obstacle. |
| `twoSided` | `bool`        | A boolean that indicates whether the obstacle is two-sided. |
| `type`     | `EObstacleType` | The type of the obstacle.                        |
