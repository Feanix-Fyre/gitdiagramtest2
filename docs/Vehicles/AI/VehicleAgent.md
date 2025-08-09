# VehicleAgent

The `VehicleAgent` class is a complex AI controller for `LandVehicle`s. It handles pathfinding, obstacle avoidance, speed control, and steering. It can navigate to a specific location, follow a pursuit target, and has a "kinematic" mode for when it's far away from the player. It also includes logic for getting unstuck and reversing.

## Enums

### ENavigationResult

This enum defines the possible results of a navigation operation.

-   `Failed`: The navigation failed.
-   `Complete`: The navigation completed successfully.
-   `Stopped`: The navigation was stopped before it could complete.

### EAgentStatus

This enum defines the current status of the agent.

-   `Inactive`: The agent is not active.
-   `MovingToRoad`: The agent is moving to the road network.
-   `OnRoad`: The agent is on the road network.

### EPathGroupStatus

This enum defines the status of the path group.

-   `Inactive`: The path group is not active.
-   `Calculating`: The path group is currently calculating a path.

### ESweepType

This enum defines the different types of sweeps that can be performed.

-   `FL`: Front left.
-   `FR`: Front right.
-   `RL`: Rear left.
-   `RR`: Rear right.

## Properties

-   `DEBUG_MODE`: If true, debug information will be logged to the console.
-   `Flags`: The `DriveFlags` for this agent.
-   `PursuitModeEnabled`: If true, the agent will pursue the `PursuitTarget`.
-   `PursuitTarget`: The transform to pursue.
-   `PursuitDistanceUpdateThreshold`: The distance the pursuit target has to move before the path is recalculated.
-   `Teleporter`: The `VehicleTeleporter` to use for getting unstuck.
-   `PositionHistoryTracker`: The `PositionHistoryTracker` to use for stuck detection.
-   `StuckTimeThreshold`: The time the vehicle has to be stuck before it is considered stuck.
-   `StuckSamples`: The number of samples to use for stuck detection.
-   `StuckDistanceThreshold`: The distance the vehicle has to move within the stuck time threshold to not be considered stuck.
-   `KinematicMode`: A boolean that indicates whether the vehicle is in kinematic mode.
-   `AutoDriving`: A boolean that indicates whether the vehicle is currently auto-driving.
-   `IsReversing`: A boolean that indicates whether the vehicle is currently reversing.
-   `TargetLocation`: The location the vehicle is currently navigating to.
-   `NavigationCalculationInProgress`: A boolean that indicates whether a navigation calculation is currently in progress.

## Methods

-   `Navigate(Vector3 location, NavigationSettings settings = null, NavigationCallback callback = null)`: Starts a navigation operation to the specified location.
-   `StopNavigating()`: Stops the current navigation operation.
-   `RecalculateNavigation()`: Recalculates the current navigation path.
-   `SweepTurn(ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)`: Performs a sweep turn to check for obstacles.
-   `BetterSweepTurn(ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out Vector3 hitPoint)`: A more advanced version of `SweepTurn`.
-   `StartReverse()`: Starts a reverse operation.
-   `IsOnVehicleGraph()`: Checks if the vehicle is on the vehicle graph.
-   `GetIsStuck()`: Checks if the vehicle is stuck.
