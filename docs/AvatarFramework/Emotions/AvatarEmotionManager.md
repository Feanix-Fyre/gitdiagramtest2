# AvatarEmotionManager

Inherits from `MonoBehaviour`.

## Description

Manages an avatar's facial emotions by blending between different `AvatarEmotionPreset`s. It uses a priority-based override system to determine which emotion should be active. For example, a temporary "surprised" emotion could have a higher priority than the base "neutral" emotion.

## Fields

-   **EmotionPresetList**: `List<AvatarEmotionPreset>` - A list of all possible emotion presets this manager can use.
-   **Avatar**: `Avatar` - A reference to the `Avatar` component to be controlled.
-   **EyeController**: `EyeController` - A reference to the avatar's eye controller.
-   **EyebrowController**: `EyebrowController` - A reference to the avatar's eyebrow controller.
-   **CurrentEmotion**: `string` (read-only) - The name of the currently active emotion preset.
-   **CurrentEmotionPreset**: `AvatarEmotionPreset` (read-only) - The `AvatarEmotionPreset` currently being displayed.
-   **IsSwitchingEmotion**: `bool` (read-only) - True if the manager is currently lerping between emotions.

## Methods

### AddEmotionOverride
`public virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)`

Adds or updates an emotion override in the stack. Overrides are identified by a unique label. The manager will always display the emotion from the override with the highest priority.

-   **Parameters:**
    -   `emotionName`: The name of the emotion preset to use.
    -   `overrideLabel`: A unique string to identify this override.
    -   `duration`: If greater than 0, the override will be automatically removed after this many seconds.
    -   `priority`: The priority of this override. Higher numbers take precedence.

### RemoveEmotionOverride
`public void RemoveEmotionOverride(string label)`

Removes an emotion override from the stack.

-   **Parameters:**
    -   `label`: The label of the override to remove.

### ClearOverrides
`public void ClearOverrides()`

Removes all overrides from the stack except for the base "Neutral" emotion.

### ConfigureNeutralFace
`public void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)`

Updates the properties of the "Neutral" emotion preset at runtime.

-   **Parameters:**
    -   `faceTex`: The texture for the neutral face.
    -   `restingBrowHeight`: The neutral height for the eyebrows.
    -   `restingBrowAngle`: The neutral angle for the eyebrows.
    -   `leftEyelidConfig`: The neutral configuration for the left eyelid.
    -   `rightEyelidConfig`: The neutral configuration for the right eyelid.

### GetEmotion
`public AvatarEmotionPreset GetEmotion(string emotion)`

Finds and returns an `AvatarEmotionPreset` from the `EmotionPresetList` by name (case-insensitive).

-   **Parameters:**
    -   `emotion`: The name of the emotion to find.
-   **Returns:** The found `AvatarEmotionPreset`, or `null` if not found.
