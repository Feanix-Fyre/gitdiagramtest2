# PathUtility

The `PathUtility` class is a static class that provides a collection of utility methods for working with paths. These methods include getting points on a path, calculating the cross-track error, and finding the closest point on a path.

## Methods

-   `GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize)`: Calculates the average of a number of points ahead of a reference point on a path.
-   `GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance)`: Gets a point on a path that is a certain distance ahead of a reference point.
-   `GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)`: Gets a point on a path that is a certain distance ahead of a reference point, starting from a specific point on the path.
-   `GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)`: Gets a point on a path that is a certain distance ahead of a specific point on the path.
-   `CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)`: Calculates the total change in angle of a path over a certain distance.
-   `CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path)`: Calculates the cross-track error (the distance between a point and the closest point on a path).
-   `GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)`: Gets the closest point on a path to a given point.
-   `GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead)`: Gets the direction of the path at a point that is a certain distance ahead of a reference point.
