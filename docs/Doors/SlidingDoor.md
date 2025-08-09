# SlidingDoor

Inherits from `MonoBehaviour`.

## Description

This class controls the behavior of a sliding door, animating its position between open and closed states using a coroutine and an `AnimationCurve`.

## Fields

-   **DoorTransform**: `Transform`
    -   A reference to the transform of the door model that will be moved.
-   **ClosedPosition**: `Transform`
    -   A transform marking the position of the door when it is closed.
-   **OpenPosition**: `Transform`
    -   A transform marking the position of the door when it is open.
-   **SlideDuration**: `float`
    -   The time in seconds it takes for the door to slide between states.
-   **SlideCurve**: `AnimationCurve`
    -   An animation curve used to control the easing of the slide animation.

## Properties

-   **IsOpen**: `bool` (read-only)
    -   The current state of the door.

## Methods

### Opened
`public virtual void Opened(EDoorSide openSide)`

This method is called by a `DoorController`'s `onDoorOpened` event. It sets `IsOpen` to true and starts the `Move` coroutine.

-   **Parameters:**
    -   `openSide`: The side from which the door was opened (unused in this class).

### Closed
`public virtual void Closed()`

This method is called by a `DoorController`'s `onDoorClosed` event. It sets `IsOpen` to false and starts the `Move` coroutine.

### Move
`private void Move()`

Starts the `Move` coroutine, stopping any existing `Move` coroutine first. The coroutine animates the `DoorTransform`'s position from its current position to the target (`OpenPosition` or `ClosedPosition`) over `SlideDuration`, using the `SlideCurve` to control the animation's timing.
