# EyeController

The `EyeController` class is a component that manages both of an avatar's eyes. It provides a higher-level interface for controlling the appearance and behavior of the left and right `Eye` components.

## Properties

-   `leftEye`: A reference to the left `Eye` component.
-   `rightEye`: A reference to the right `Eye` component.
-   `eyeSpacing`: The spacing between the eyes.
-   `eyeHeight`: The vertical position of the eyes.
-   `eyeSize`: The size of the eyes.
-   `BlinkingEnabled`: A boolean that enables or disables automatic blinking.
-   `EyesOpen`: A boolean that indicates whether the eyes are currently open.

## Methods

### `ApplySettings()`

Applies all the public settings to the left and right eyes, including spacing, size, color, and material.

### `SetEyeballTint(Color col)`

Sets the tint color of the eyeballs.

### `SetEyesOpen(bool open)`

Opens or closes the eyes.

### `SetPupilDilation(float dilation, bool writeDefault = true)`

Sets the dilation of the pupils.

### `ForceBlink()`

Triggers a blink on both eyes simultaneously.

### `LookAt(Vector3 position, bool instant = false)`

Makes both eyes look at a specific position in world space.
