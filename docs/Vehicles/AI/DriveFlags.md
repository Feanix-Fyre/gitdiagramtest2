# DriveFlags

The `DriveFlags` class is a data container for a set of flags that control the behavior of a `VehicleAgent`.

## Enums

### EObstacleMode

This enum defines the different obstacle avoidance modes.

-   `Default`: The agent will avoid all obstacles.
-   `IgnoreAll`: The agent will ignore all obstacles.
-   `IgnoreOnlySquishy`: The agent will ignore "squishy" obstacles (e.g., players, NPCs).

## Public Properties

| Property                  | Type          | Description                                                              |
| ------------------------- | ------------- | ------------------------------------------------------------------------ |
| `OverrideSpeed`           | `bool`        | If true, the agent will use the `OverriddenSpeed` instead of the calculated speed. |
| `OverriddenSpeed`         | `float`       | The speed to use when `OverrideSpeed` is true.                           |
| `OverriddenReverseSpeed`  | `float`       | The speed to use when reversing and `OverrideSpeed` is true.             |
| `SpeedLimitMultiplier`    | `float`       | A multiplier for the speed limit.                                        |
| `IgnoreTrafficLights`     | `bool`        | If true, the agent will ignore traffic lights.                           |
| `UseRoads`                | `bool`        | If true, the agent will try to stay on the road.                         |
| `StuckDetection`          | `bool`        | If true, the agent will try to detect when it is stuck and take action.  |
| `ObstacleMode`            | `EObstacleMode` | The obstacle avoidance mode to use.                                      |
| `AutoBrakeAtDestination`  | `bool`        | If true, the agent will automatically brake when it reaches its destination. |
| `TurnBasedSpeedReduction` | `bool`        | If true, the agent will reduce its speed when turning.                   |

## Public Methods

| Method       | Return Type | Description             |
| ------------ | ----------- | ----------------------- |
| `ResetFlags()` | `void`      | Resets all flags to their default values. |
