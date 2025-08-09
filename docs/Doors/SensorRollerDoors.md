# SensorRollerDoors

Inherits from `RollerDoor`.

## Description

This class extends `RollerDoor` to create an automatic roller door that opens and closes based on vehicle detection. It uses `VehicleDetector` triggers to determine when to open or close.

## Fields

-   **Detector**: `VehicleDetector`
    -   The main trigger volume used to detect if any vehicle is near the door.
-   **ClipDetector**: `VehicleDetector`
    -   An additional, likely smaller, trigger volume used to prevent the door from closing on a vehicle.
-   **DetectPlayerOccupiedVehiclesOnly**: `bool`
    -   If true, the door will only open for vehicles that have a player driver.

## Core Logic

-   **Update Loop**: The `Update` method contains the core logic for opening and closing the door.
    1.  It first checks `CanOpen()`. If it returns false, the door is closed immediately.
    2.  If `Detector` has detected any vehicles:
        -   It checks if the `ClipDetector` is also triggered, which forces the door to open to prevent clipping.
        -   If `DetectPlayerOccupiedVehiclesOnly` is true, it iterates through the detected vehicles to see if any have a `DriverPlayer`. If so, it opens the door.
        -   If `DetectPlayerOccupiedVehiclesOnly` is false, it opens the door for any vehicle.
    3.  If `Detector` is empty, it closes the door.
