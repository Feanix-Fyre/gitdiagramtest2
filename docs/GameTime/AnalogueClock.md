# AnalogueClock

Inherits from `MonoBehaviour`.

## Description

This class controls a 3D analogue clock model, updating the rotation of its minute and hour hands to match the in-game time provided by the `TimeManager`.

## Fields

-   **MinHand**: `Transform`
    -   The transform for the minute hand of the clock.
-   **HourHand**: `Transform`
    -   The transform for the hour hand of the clock.
-   **RotationAxis**: `Vector3`
    -   The axis around which the hands should rotate (e.g., `Vector3.forward` for a clock facing the Z-axis).
-   **onNoon**: `UnityEvent`
    -   An event invoked when the in-game time reaches 12:00 (noon).
-   **onMidnight**: `UnityEvent`
    -   An event invoked when the in-game time reaches 00:00 (midnight).

## Core Logic

-   **Initialization (`Start`)**: The clock subscribes its `MinPass` method to the `TimeManager`'s `onMinutePass` event. This ensures the clock updates every time the in-game time changes.
-   **Time Update (`MinPass`)**:
    1.  This method is called every in-game minute.
    2.  It gets the current time from the `TimeManager`.
    3.  It calculates the rotation for the minute hand (360 degrees per 60 minutes).
    4.  It calculates the rotation for the hour hand (360 degrees per 12 hours), adding a fractional rotation based on the current minute for smooth movement.
    5.  It applies these rotations to the `MinHand` and `HourHand` transforms.
    6.  It checks if the time is exactly noon or midnight and invokes the corresponding events.
-   **Cleanup (`OnDestroy`)**: Unsubscribes from the `onMinutePass` event to prevent memory leaks.
