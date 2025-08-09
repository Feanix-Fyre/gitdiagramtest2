# ACColorPickerReplicator

Inherits from `ACReplicator`.

## Description

This class replicates color changes from the avatar settings to an `HSVPicker.ColorPicker` UI element. When the avatar settings are updated, it sets the color picker's current color to the value of the specified property.

## Fields

-   **picker**: `HSVPicker.ColorPicker`
    -   The color picker UI element to be updated.

## Methods

### AvatarSettingsChanged
`protected override void AvatarSettingsChanged(AvatarSettings newSettings)`

This method is called when the avatar settings change. It updates the `picker.CurrentColor` with the new color value from the `newSettings`.

-   **Parameters:**
    -   `newSettings`: The new avatar settings.
