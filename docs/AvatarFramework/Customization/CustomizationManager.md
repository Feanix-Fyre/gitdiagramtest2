# CustomizationManager

Inherits from `Singleton<CustomizationManager>`.

## Description

A manager for a developer-focused avatar customization scene. It handles loading and applying `AvatarSettings`, and provides a suite of public methods that can be hooked up to UI elements (sliders, color pickers, etc.) to modify the appearance of a template avatar in real-time.

## Delegates

### AvatarSettingsChanged
`public delegate void AvatarSettingsChanged(AvatarSettings settings);`

A delegate for events that are fired when the avatar settings change.

## Fields

-   **TemplateAvatar**: `Avatar`
    -   The avatar instance that is being modified.
-   **SaveInputField**: `TMP_InputField`
    -   An input field for naming new settings files.
-   **LoadInputField**: `TMP_InputField`
    -   An input field for loading existing settings files by name.
-   **OnAvatarSettingsChanged**: `AvatarSettingsChanged`
    -   An event that is invoked whenever the `ActiveSettings` are changed.
-   **DefaultSettings**: `AvatarSettings`
    -   The default settings to load on start.

## Methods

### LoadSettings
`public void LoadSettings(AvatarSettings loadedSettings)`

Loads a given `AvatarSettings` object, applies it to the `TemplateAvatar`, and invokes the `OnAvatarSettingsChanged` event.

-   **Parameters:**
    -   `loadedSettings`: The `AvatarSettings` object to load.

### LoadSettings
`public void LoadSettings(string settingsName, bool editOriginal = false)`

Loads an `AvatarSettings` `ScriptableObject` from the `Resources/CharacterSettings/` folder by name.

-   **Parameters:**
    -   `settingsName`: The name of the settings file (without extension).
    -   `editOriginal`: If true, modifies the original `ScriptableObject` asset directly. Otherwise, works on an instantiated copy.

### UI Event Handlers
This class contains numerous public methods designed to be called from UI elements like sliders and color pickers. These methods modify a specific property of the `ActiveSettings` and then call the corresponding `Apply` method on the `TemplateAvatar` to visually update it.

Examples:
-   `GenderChanged(float genderScale)`
-   `WeightChanged(float weightScale)`
-   `SkinColorChanged(Color col)`
-   `HairChanged(Accessory newHair)`
-   `FaceLayerChanged(FaceLayer layer, int index)`
-   `AccessoryChanged(Accessory acc, int index)`
-   ...and many others for various avatar properties.
