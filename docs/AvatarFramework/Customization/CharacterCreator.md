# CharacterCreator

Inherits from `Singleton<CharacterCreator>`.

## Description

The main controller for the character creation screen. It manages the UI, the avatar rig being customized, and the `BasicAvatarSettings` that store the customization data. It handles opening and closing the creator, applying settings, and finalizing the character.

## Enums

### ECategory
-   `Body`
-   `Hair`
-   `Face`
-   `Eyes`
-   `Eyebrows`
-   `Clothing`
-   `Accessories`

## Fields

-   **Fields**: `List<BaseCharacterCreatorField>` - A list of all the fields in the character creator UI.
-   **Container**: `Transform` - The root transform of the character creator UI.
-   **CameraPosition**: `Transform` - The position the camera should move to when the creator is open.
-   **RigContainer**: `Transform` - The container for the avatar rig.
-   **Rig**: `Avatar` - The avatar rig being customized.
-   **Canvas**: `Canvas` - The UI canvas for the creator.
-   **CanvasAnimation**: `UnityEngine.Animation` - Animation component for UI transitions.
-   **DemoCreator**: `bool` - If true, this is a demo version of the creator.
-   **DefaultSettings**: `BasicAvatarSettings` - The default settings to use.
-   **Presets**: `List<BasicAvatarSettings>` - A list of preset appearance settings.
-   **onComplete**: `UnityEvent<BasicAvatarSettings>` - Event invoked when creation is complete.
-   **onCompleteWithClothing**: `UnityEvent<BasicAvatarSettings, List<ClothingInstance>>` - Event invoked when creation is complete, including clothing data.
-   **IsOpen**: `bool` (read-only) - Is the character creator currently open?
-   **ActiveSettings**: `BasicAvatarSettings` (read-only) - The settings currently being modified.

## Methods

### Open
`public void Open(BasicAvatarSettings initialSettings, bool showUI = true)`

Opens the character creator interface, disabling player movement and showing the customization UI.

-   **Parameters:**
    -   `initialSettings`: The settings to start with.
    -   `showUI`: Whether to show the UI immediately.

### ShowUI
`public void ShowUI()`

Enables the UI canvas and plays the fade-in animation.

### Close
`public void Close()`

Closes the character creator interface and re-enables player controls.

### Done
`public void Done()`

Finalizes the character creation process, invokes the completion events, and closes the interface.

### SliderChanged
`public void SliderChanged(float newVal)`

Rotates the character rig based on a slider's value (0.0 to 1.0).

### SetValue<T>
`public T SetValue<T>(string fieldName, T value, ClothingDefinition definition)`

Sets a value in the `ActiveSettings`. Also handles preset selection and tracks clothing definitions.

-   **Parameters:**
    -   `fieldName`: The name of the property to set.
    -   `value`: The new value.
    -   `definition`: The `ClothingDefinition` if the field is for a clothing item.
-   **Returns:** The value that was set.

### SelectPreset
`public void SelectPreset(string presetName)`

Loads a `BasicAvatarSettings` preset and applies it to the character.

-   **Parameters:**
    -   `presetName`: The name of the preset to load.

### RefreshCategory
`public void RefreshCategory(ECategory category)`

Refreshes a specific part of the avatar's appearance based on the active settings.

-   **Parameters:**
    -   `category`: The category of appearance to refresh.
