# VehicleModStation

The `VehicleModStation` class manages a vehicle modification station. When a vehicle is brought to the station, it takes control of the camera, player movement, and UI, and opens the `VehicleModMenu`. It also positions the vehicle at a specific point.

## Properties

-   `currentVehicle`: The `LandVehicle` that is currently at the station.
-   `isOpen`: A boolean that indicates whether the station is currently open.

## Methods

-   `Open(LandVehicle vehicle)`: Opens the station with the specified vehicle.
-   `Close()`: Closes the station.
