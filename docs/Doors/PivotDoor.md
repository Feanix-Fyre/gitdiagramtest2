# PivotDoor

Inherits from `MonoBehaviour`.

## Description

This class controls the physical swinging animation of a standard pivot door. It is designed to be controlled by a `DoorController`, which calls the `Opened` and `Closed` methods.

## Fields

-   **DoorTransform**: `Transform`
    -   A reference to the transform of the door model that will be rotated.
-   **FlipSide**: `bool`
    -   If true, the inward and outward opening directions are swapped.
-   **OpenInwardsAngle**: `float`
    -   The target Y-axis rotation angle when the door opens inwards.
-   **OpenOutwardsAngle**: `float`
    -   The target Y-axis rotation angle when the door opens outwards.
-   **SwingSpeed**: `float`
    -   The speed at which the door animates towards its target angle.

## Core Logic

-   **Animation**: The `LateUpdate` method continuously uses `Quaternion.Lerp` to smoothly rotate the `DoorTransform` towards the `targetDoorAngle`. This creates the opening and closing animation.

## Public Methods

### Opened
`public virtual void Opened(EDoorSide openSide)`

This method is called by a `DoorController`'s `onDoorOpened` event. It sets the `targetDoorAngle` based on which side the door was opened from (`Interior` or `Exterior`) and whether the `FlipSide` flag is set.

-   **Parameters:**
    -   `openSide`: The side from which the door was opened.

### Closed
`public virtual void Closed()`

This method is called by a `DoorController`'s `onDoorClosed` event. It sets the `targetDoorAngle` to `0`, causing the door to swing shut.
