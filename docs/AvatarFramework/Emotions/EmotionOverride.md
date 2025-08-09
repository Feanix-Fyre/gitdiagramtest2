# EmotionOverride

A class that represents a request to override the avatar's current emotion.

## Description

This class is used by the `AvatarEmotionManager` to manage a stack of emotion requests. Each override has a priority, and the manager will always display the emotion from the override with the highest priority.

## Fields

-   **Emotion**: `string`
    -   The name of the emotion to display (e.g., "Happy", "Angry").
-   **Label**: `string`
    -   A unique label to identify this specific override request. This is used to update or remove the override later.
-   **Priority**: `int`
    -   The priority of this override. Higher numbers take precedence over lower ones.

## Constructors

### EmotionOverride
`public EmotionOverride(string emotion, string label, int priority)`

Creates a new `EmotionOverride` instance.

-   **Parameters:**
    -   `emotion`: The name of the emotion.
    -   `label`: The unique identifier for this override.
    -   `priority`: The priority level of this override.
