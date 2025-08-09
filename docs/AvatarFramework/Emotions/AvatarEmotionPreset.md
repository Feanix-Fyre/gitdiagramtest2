# AvatarEmotionPreset

A serializable class that defines a specific facial emotion.

## Description

This class holds all the data required to represent a single facial emotion, including the face texture, eyelid positions, and eyebrow transformations. These presets are used by the `AvatarEmotionManager` to control the avatar's expression.

## Fields

-   **PresetName**: `string`
    -   The name of the emotion preset (e.g., "Happy", "Sad", "Angry").
-   **FaceTexture**: `Texture2D`
    -   The texture to apply to the face material for this emotion.
-   **LeftEyeRestingState**: `Eye.EyeLidConfiguration`
    -   The configuration for the left eyelid.
-   **RightEyeRestingState**: `Eye.EyeLidConfiguration`
    -   The configuration for the right eyelid.
-   **BrowAngleChange_L**: `float`
    -   The angle change for the left eyebrow.
-   **BrowAngleChange_R**: `float`
    -   The angle change for the right eyebrow.
-   **BrowHeightChange_L**: `float`
    -   The height change for the left eyebrow.
-   **BrowHeightChange_R**: `float`
    -   The height change for the right eyebrow.

## Methods

### Lerp
`public static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)`

Linearly interpolates between two emotion presets. This is used to create smooth transitions between emotions.

-   **Parameters:**
    -   `start`: The starting preset.
    -   `end`: The target preset.
    -   `neutralPreset`: The neutral preset, used as a base for additive changes.
    -   `lerp`: The interpolation factor, from 0.0 to 1.0.
-   **Returns:** A new `AvatarEmotionPreset` representing the interpolated state.
