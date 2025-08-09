# VehicleDetector

The `VehicleDetector` class is a component that detects vehicles that enter its trigger.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `vehicles` | `List<LandVehicle>` | A list of all vehicles that are currently in the trigger. |
| `closestVehicle` | `LandVehicle` | The closest vehicle to the detector. |
| `IgnoreNewDetections` | `bool` | If `true`, new detections will be ignored. |

## Methods

### `SetIgnoreNewCollisions(bool ignore)`

Sets whether new collisions should be ignored.

**Parameters:**

* `ignore`: If `true`, new collisions will be ignored.

### `AreAnyVehiclesOccupied()`

Returns `true` if any of the vehicles in the trigger are occupied.

**Returns:** `bool`

### `Clear()`

Clears the list of vehicles.
