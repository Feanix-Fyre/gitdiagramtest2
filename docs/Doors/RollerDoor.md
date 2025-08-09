# RollerDoor

Inherits from `MonoBehaviour`.

## Description

This class controls the behavior of a roller door, animating its position between an open and closed state.

## Fields

-   **Door**: `Transform`
    -   A reference to the transform of the door model that will be moved.
-   **LocalPos_Open**: `Vector3`
    -   The target local position of the `Door` transform when the door is open.
-   **LocalPos_Closed**: `Vector3`
    -   The target local position of the `Door` transform when the door is closed.
-   **LerpTime**: `float`
    -   The time in seconds it takes for the door to animate between the open and closed positions.
-   **Blocker**: `GameObject`
    -   An optional GameObject (likely a collider) that is activated when the door is closed and deactivated when it's open.

## Properties

-   **IsOpen**: `bool` (read-only)
    -   The current state of the door.

## Core Logic

-   **Animation**: The `LateUpdate` method continuously uses `Vector3.Lerp` to smoothly move the `Door` transform towards its target position (`LocalPos_Open` or `LocalPos_Closed`) over the `LerpTime`.

## Public Methods

### Open
`public void Open()`

Starts the process of opening the door. It sets `IsOpen` to true and resets the animation timer.

### Close
`public void Close()`

Starts the process of closing the door. It sets `IsOpen` to false and resets the animation timer.

### CanOpen
`protected virtual bool CanOpen()`

A virtual method that can be overridden by derived classes to add conditions for whether the door is allowed to open. By default, it always returns `true`.
