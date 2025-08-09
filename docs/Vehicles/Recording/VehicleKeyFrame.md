# VehicleKeyFrame

The `VehicleKeyFrame` class is a data container for a single keyframe of a vehicle recording. It stores the vehicle's position, rotation, and other data, as well as a list of `WheelTransform`s for each wheel.

## Classes

### WheelTransform

This class is a data container for the state of a single wheel.

-   `yPos`: The local y-position of the wheel.
-   `rotation`: The local rotation of the wheel.

## Properties

-   `position`: The position of the vehicle.
-   `rotation`: The rotation of the vehicle.
-   `brakesApplied`: A boolean that indicates whether the brakes were applied in this keyframe.
-   `reversing`: A boolean that indicates whether the vehicle was reversing in this keyframe.
-   `headlightsOn`: A boolean that indicates whether the headlights were on in this keyframe.
-   `wheels`: A list of `WheelTransform`s for each wheel.
