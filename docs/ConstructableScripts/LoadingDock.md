# LoadingDock

Inherits from `Constructable_GridBased`.

## Description

This class represents a loading dock building where vehicles can park. It manages the state of the dock (occupied or empty), controls indicator lights, and has a mechanism for reserving the dock for a specific vehicle, which closes a gate and blocks other vehicles from entering.

## Fields

-   **vehicleDetector**: `VehicleDetector`
    -   A component used to detect when a vehicle is inside the dock area.
-   **redLightMeshes / greenLightMeshes**: `MeshRenderer[]`
    -   Arrays of mesh renderers for the red and green indicator lights.
-   **gateAnim**: `Animation`
    -   The animation component for the reservation gate.
-   **reservationBlocker**: `Collider`
    -   A collider that is enabled when the dock is reserved to physically block entry.
-   **vehiclePosition**: `Transform`
    -   A transform indicating the ideal parking spot for a vehicle.

## Properties

-   **isOccupied**: `bool` (read-only)
    -   True if the `vehicleDetector` has detected a vehicle.
-   **reservant**: `LandVehicle` (read-only)
    -   The vehicle that has currently reserved this dock.

## Core Logic

-   **Indicator Lights**: In `LateUpdate`, the materials on the `redLightMeshes` and `greenLightMeshes` are swapped between "On" and "Off" states to indicate if the dock is occupied (red) or available (green).
-   **Side Walls**: The `sideWalls` animate up and down based on whether a vehicle is present, likely for visual effect.
-   **Reservation**: The `SetReservant` method is the core of the reservation system.
    -   When a vehicle is set as the `reservant`, the `gateAnim` plays its "Close" animation.
    -   The `reservationBlocker` collider is enabled to prevent other vehicles from entering.
    -   Physics collisions are ignored between the `reservant` vehicle and the `reservationBlocker` so the intended vehicle can pass through.
    -   When the reservation is cleared (`_res` is null), the gate opens and the blocker is disabled.

## Public Methods

### CanBeDestroyed
`public override bool CanBeDestroyed(out string reason)`

Overrides the base method to prevent the dock from being destroyed if it is currently reserved.

-   **Parameters:**
    -   `reason`: An `out` parameter that will be set to "Reserved for dealer" if destruction is blocked.
-   **Returns:** `false` if reserved, otherwise calls the base method.

### SetReservant
`public void SetReservant(LandVehicle _res)`

Reserves the loading dock for a specific vehicle or clears the reservation.

-   **Parameters:**
    -   `_res`: The `LandVehicle` to reserve the dock for, or `null` to clear the reservation.
