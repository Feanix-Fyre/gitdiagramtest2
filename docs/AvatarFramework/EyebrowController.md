# EyebrowController

The `EyebrowController` class is a component that manages both of an avatar's eyebrows. It provides a higher-level interface for applying settings from an `AvatarSettings` object to the individual `Eyebrow` components.

## Properties

-   `leftBrow`: A reference to the left `Eyebrow` component.
-   `rightBrow`: A reference to the right `Eyebrow` component.

## Methods

### `ApplySettings(AvatarSettings settings)`

Applies all the eyebrow-related settings from the given `AvatarSettings` object to both eyebrows. This includes scale, thickness, resting angle, and color.

### `SetLeftBrowRestingHeight(float normalizedHeight)`

Sets the resting height of the left eyebrow.

### `SetRightBrowRestingHeight(float normalizedHeight)`

Sets the resting height of the right eyebrow.
