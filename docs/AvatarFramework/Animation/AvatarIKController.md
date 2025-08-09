# AvatarIKController

The `AvatarIKController` class is a component that controls the Inverse Kinematics (IK) of an avatar. It specifically manages the `BipedIK` component from the `RootMotion.FinalIK` library to control the avatar's limbs.

## Properties

-   `BodyIK`: A reference to the `BipedIK` component that controls the avatar's body IK.

## Methods

### `SetIKActive(bool active)`

Activates or deactivates the `BipedIK` component.

### `OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)`

Overrides the default bend targets for the avatar's legs. This is useful for situations where the legs need to bend in a specific way, such as when riding a skateboard.

### `ResetLegBendTargets()`

Resets the leg bend targets to their default values.
