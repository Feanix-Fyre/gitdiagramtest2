# SpeedZone

The `SpeedZone` class defines a zone that affects the speed of vehicles.

## Public Properties

| Property     | Type                | Description                                      |
| ------------ | ------------------- | ------------------------------------------------ |
| `speedZones` | `List<SpeedZone>`   | A static list of all `SpeedZone`s in the scene. |
| `col`        | `BoxCollider`       | The collider that defines the zone.              |
| `speed`      | `float`             | The speed limit in the zone.                     |

## Public Methods

| Method           | Return Type         | Description                               |
| ---------------- | ------------------- | ----------------------------------------- |
| `GetSpeedZones(Vector3 point)` | `List<SpeedZone>` | Gets all the `SpeedZone`s that contain a given point. |
