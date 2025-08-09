# SoilChunk

Inherits from `Clickable`.

## Description

This class represents a chunk of soil, likely part of a larger model (like a bag of soil). It is designed to be "clicked" by the player, triggering an animation where the chunk moves and scales to a target transform. This is probably used in the `PourSoilTask` to create the effect of soil being scooped out of a bag.

## Fields

-   **EndTransform**: `Transform`
    -   A transform that defines the target position, rotation, and scale for the soil chunk at the end of its animation.
-   **LerpTime**: `float`
    -   The duration of the animation, in seconds.

## Properties

-   **CurrentLerp**: `float` (read-only)
    -   The current progress of the animation, from 0.0 to 1.0.

## Methods

### SetLerpedTransform
`public void SetLerpedTransform(float _lerp)`

Sets the transform of the soil chunk to an interpolated state between its starting transform and the `EndTransform`.

-   **Parameters:**
    -   `_lerp`: The interpolation factor (0.0 to 1.0).

### StartClick
`public override void StartClick(RaycastHit hit)`

Overrides the base `StartClick` method. When the player clicks on this chunk:
1.  It disables itself so it cannot be clicked again.
2.  It starts a coroutine that animates the chunk by calling `SetLerpedTransform` over `LerpTime`.

### StopLerp
`public void StopLerp()`

Stops the animation coroutine if it is currently running.
