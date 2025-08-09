# AvatarFootstepDetector

The `AvatarFootstepDetector` class is a component that detects when an avatar's feet touch the ground. When a step is detected, it triggers an event with information about the surface material.

## Properties

-   `Avatar`: A reference to the `Avatar` component.
-   `ReferencePoint`: A `Transform` used as a reference point for detecting steps.
-   `LeftBone`: The `Transform` of the left foot bone.
-   `RightBone`: The `Transform` of the right foot bone.
-   `StepThreshold`: The distance threshold for detecting a step.
-   `onStep`: A `UnityEvent` that is invoked when a step is detected. It passes the `EMaterialType` of the surface and a float value.

## Methods

### `TriggerStep()`

This method is called when a step is detected. It checks if the avatar is grounded and, if so, invokes the `onStep` event.

### `IsGrounded(out EMaterialType surfaceType)`

Checks if the avatar is on the ground and determines the type of surface.

-   **Parameters:**
    -   `surfaceType`: An `out` parameter that will be populated with the `EMaterialType` of the surface.
-   **Returns:** `true` if the avatar is grounded, `false` otherwise.
