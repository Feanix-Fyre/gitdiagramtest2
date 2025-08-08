# Zone

The `Zone` class defines a 3D zone in the world using a series of points. It can calculate the distance from the player to the nearest point on the zone's perimeter.

## Public Constants

| Constant          | Type    | Description                                                              |
| ----------------- | ------- | ------------------------------------------------------------------------ |
| `UPDATE_INTERVAL` | `float` | The interval in seconds at which the zone recalculates the player's distance. |

## Public Properties

| Property            | Type      | Description                                                        |
| ------------------- | --------- | ------------------------------------------------------------------ |
| `PointContainer`    | `Transform` | A transform that contains the points that define the zone.         |
| `IsClosed`          | `bool`    | A flag indicating whether the zone is a closed polygon.            |
| `VerticalSize`      | `float`   | The vertical size of the zone.                                     |
| `ZoneColor`         | `Color`   | The color of the zone's gizmo.                                     |
| `LocalPlayerDistance` | `float`   | The distance from the local player to the zone.                    |

## Public Methods

| Method        | Return Type | Description                                             |
| ------------- | ----------- | ------------------------------------------------------- |
| `Recalculate()` | `void`      | Recalculates the distance from the local player to the zone. |
