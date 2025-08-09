# NavigationUtility

The `NavigationUtility` class is a static class that provides utility methods for calculating vehicle navigation paths. It can calculate a path that uses a combination of off-road and on-road sections, and it can also smooth the path to make it more suitable for a vehicle to follow.

## Enums

### ENavigationCalculationResult

This enum defines the possible results of a navigation calculation.

-   `Success`: The calculation was successful.
-   `Failed`: The calculation failed.

## Delegates

### NavigationCalculationCallback

This delegate is used for the callback that is invoked when a navigation calculation is complete.

-   `result`: The result of the calculation.
-   `path`: The calculated path.

### PathGroupEvent

This delegate is used for the callback that is invoked when a path group has been calculated.

-   `calculatedGroup`: The calculated path group.

## Methods

-   `CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationCalculationCallback callback)`: Calculates a navigation path from a start position to a destination.
-   `DrawPath(PathGroup group, float duration = 10f)`: Draws a path group in the editor.
-   `SampleVehicleGraph(Vector3 destination)`: Samples the vehicle graph at a given position.
-   `GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)`: Gets the closest point on a finite line to a given point.
