# AvatarLookController

The `AvatarLookController` class is a component that controls where an avatar is looking. It uses the `AimIK` component from the `RootMotion.FinalIK` library to procedurally adjust the avatar's head and eyes to look at a specific target.

## Properties

-   `Aim`: A reference to the `AimIK` component that controls the looking behavior.
-   `HeadBone`: The `Transform` of the avatar's head bone.
-   `LookForwardTarget`: A `Transform` that represents the default "look forward" position.
-   `Eyes`: A reference to the `EyeController` component.
-   `AutoLookAtPlayer`: A boolean that, if true, makes the avatar automatically look at the nearest player.
-   `ForceLookTarget`: A `Transform` that can be set to force the avatar to look at a specific target.

## Methods

### `OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)`

Overrides the default look target with a new position.

-   **Parameters:**
    -   `targetPosition`: The position to look at.
    -   `priority`: The priority of this override. Higher priority overrides take precedence.
    -   `rotateBody`: Whether to rotate the avatar's body to face the target.

### `OverrideIKWeight(float weight)`

Overrides the weight of the `AimIK` solver.

### `ResetIKWeight()`

Resets the `AimIK` solver's weight to its default value.
