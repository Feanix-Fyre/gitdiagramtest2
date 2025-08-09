# VehicleRecoveryPoint

The `VehicleRecoveryPoint` class represents a point where a vehicle can be recovered.

## Public Properties

| Property         | Type                         | Description                                      |
| ---------------- | ---------------------------- | ------------------------------------------------ |
| `recoveryPoints` | `List<VehicleRecoveryPoint>` | A static list of all `VehicleRecoveryPoint`s in the scene. |

## Public Methods

| Method                        | Return Type           | Description                               |
| ----------------------------- | --------------------- | ----------------------------------------- |
| `GetClosestRecoveryPoint(Vector3 pos)` | `VehicleRecoveryPoint` | Gets the closest recovery point to a given position. |
