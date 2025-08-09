# AvatarAnimation

The `AvatarAnimation` class is responsible for managing all animations for an avatar. This includes handling movement, crouching, jumping, sitting, and reacting to various game events like skateboarding and ragdolling. It also manages animation culling and LODing with an impostor system.

## Enums

### `EFlinchType`

Defines the types of flinch animations.

-   `Light`
-   `Heavy`

### `EFlinchDirection`

Defines the directions for flinch animations.

-   `Forward`
-   `Backward`
-   `Left`
-   `Right`

## Properties

-   `animator`: The `Animator` component that controls the avatar's animations.
-   `IsCrouched`: A boolean that indicates whether the avatar is currently crouched.
-   `IsSeated`: A boolean that indicates whether the avatar is currently seated.
-   `CurrentSeat`: The `AvatarSeat` that the avatar is currently occupying.

## Methods

### `SetDirection(float dir)`

Sets the direction parameter in the animator.

### `SetStrafe(float strafe)`

Sets the strafe parameter in the animator.

### `SetGrounded(bool grounded)`

Sets the `isGrounded` boolean parameter in the animator.

### `Jump()`

Triggers the jump animation.

### `Flinch(Vector3 forceDirection, EFlinchType flinchType)`

Triggers a flinch animation in the direction of the applied force.

### `PlayStandUpAnimation()`

Plays an animation to make the avatar stand up from a ragdoll state.

### `SetSeat(AvatarSeat seat)`

Makes the avatar sit in the specified `AvatarSeat`.

### `SkateboardMounted(Skateboard board)`

Sets up the avatar's animation and IK for riding a skateboard.

### `SkateboardDismounted()`

Resets the avatar's animation and IK after dismounting a skateboard.
