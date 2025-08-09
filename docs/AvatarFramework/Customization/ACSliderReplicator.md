# ACSliderReplicator

Inherits from `ACReplicator`.

## Description

This class replicates a float value from the avatar settings to a `Slider` UI element. When the avatar settings are updated, it sets the slider's value to the value of the specified property without invoking the slider's `OnValueChanged` event.

## Fields

-   **slider**: `Slider`
    -   The slider UI element to be updated.

## Methods

### AvatarSettingsChanged
`protected override void AvatarSettingsChanged(AvatarSettings newSettings)`

This method is called when the avatar settings change. It updates the `slider`'s value with the new float value from the `newSettings`.

-   **Parameters:**
    -   `newSettings`: The new avatar settings.
