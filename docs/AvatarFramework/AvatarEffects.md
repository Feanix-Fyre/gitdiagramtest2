# AvatarEffects

The `AvatarEffects` class manages various visual and audio effects for an avatar. It works in conjunction with the `Avatar` class to apply these effects, which can range from particle effects and sounds to modifications of the avatar's appearance.

## Properties

-   `Avatar`: A reference to the `Avatar` component that these effects are applied to.
-   `StinkParticles`: Particle systems for creating a "stinking" effect.
-   `VomitParticles`: A particle system for the vomit effect.
-   `HeadPoofParticles`: A particle system for a "poof" effect around the head.
-   `FartParticles`: A particle system for a fart effect.
-   ...and many more particle systems and audio sources for various effects.

## Methods

### `SetStinkParticlesActive(bool active, bool mirror = true)`

Activates or deactivates the stink particle effect.

-   **Parameters:**
    -   `active`: Whether to activate or deactivate the effect.
    -   `mirror`: Whether to mirror the effect to other linked `AvatarEffects` components.

### `TriggerSick(bool mirror = true)`

Triggers a sequence of effects to make the avatar appear sick, culminating in a vomit effect.

### `SetAntiGrav(bool active, bool mirror = true)`

Activates or deactivates the anti-gravity effect.

### `VanishHair(bool mirror = true)`

Makes the avatar's hair disappear with a "poof" effect.

### `ReturnHair(bool mirror = true)`

Makes the avatar's hair reappear with a "poof" effect.

### `OverrideHairColor(Color color, bool mirror = true)`

Changes the avatar's hair color with a "poof" effect.

### `EnableLaxative(bool mirror = true)`

Enables a recurring fart effect.

### `SetFireActive(bool active, bool mirror = true)`

Activates or deactivates a fire effect on the avatar.

### `SetBigHeadActive(bool active, bool mirror = true)`

Increases the size of the avatar's head.

### `SetSkinColorInverted(bool inverted, bool mirror = true)`

Inverts the avatar's skin color.

### `SetZombified(bool zombified, bool mirror = true)`

Applies a "zombified" appearance to the avatar, including changes to skin color, eyes, and emotion.
