# Settings

The `Settings` class is a persistent singleton that manages all game settings.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `DisplaySettings` | `DisplaySettings` | The display settings. |
| `UnappliedDisplaySettings` | `DisplaySettings` | The unapplied display settings. |
| `GraphicsSettings` | `GraphicsSettings` | The graphics settings. |
| `AudioSettings` | `AudioSettings` | The audio settings. |
| `InputSettings` | `InputSettings` | The input settings. |
| `InputActions` | `InputActionAsset` | The input action asset. |
| `GameInput` | `GameInput` | The game input. |
| `SSAO` | `ScriptableRendererFeature` | The screen space ambient occlusion feature. |
| `GodRays` | `ScriptableRendererFeature` | The god rays feature. |
| `LookSensitivity` | `float` | The look sensitivity. |
| `InvertMouse` | `bool` | If `true`, the mouse will be inverted. |
| `CameraFOV` | `float` | The camera field of view. |
| `SprintMode` | `InputSettings.EActionMode` | The sprint mode. |
| `CameraBobIntensity` | `float` | The camera bob intensity. |
| `onDisplayChanged` | `Action` | An event that is invoked when the display settings are changed. |
| `onInputsApplied` | `Action` | An event that is invoked when the input settings are applied. |
| `unitType` | `UnitType` | The unit type. |
| `PausingFreezesTime` | `bool` | If `true`, pausing the game will freeze time. |

## Methods

### `ApplyDisplaySettings(DisplaySettings settings)`

Applies the display settings.

**Parameters:**

* `settings`: The display settings to apply.

### `ReloadGraphicsSettings()`

Reloads the graphics settings.

### `ApplyGraphicsSettings(GraphicsSettings settings)`

Applies the graphics settings.

**Parameters:**

* `settings`: The graphics settings to apply.

### `ReloadAudioSettings()`

Reloads the audio settings.

### `ApplyAudioSettings(AudioSettings settings)`

Applies the audio settings.

**Parameters:**

* `settings`: The audio settings to apply.

### `ReloadInputSettings()`

Reloads the input settings.

### `ApplyInputSettings(InputSettings settings)`

Applies the input settings.

**Parameters:**

* `settings`: The input settings to apply.

### `WriteDisplaySettings(DisplaySettings settings)`

Writes the display settings to the player prefs.

**Parameters:**

* `settings`: The display settings to write.

### `ReadDisplaySettings()`

Reads the display settings from the player prefs.

**Returns:** `DisplaySettings`

### `WriteGraphicsSettings(GraphicsSettings settings)`

Writes the graphics settings to the player prefs.

**Parameters:**

* `settings`: The graphics settings to write.

### `ReadGraphicsSettings()`

Reads the graphics settings from the player prefs.

**Returns:** `GraphicsSettings`

### `WriteAudioSettings(AudioSettings settings)`

Writes the audio settings to the player prefs.

**Parameters:**

* `settings`: The audio settings to write.

### `ReadAudioSettings()`

Reads the audio settings from the player prefs.

**Returns:** `AudioSettings`

### `WriteInputSettings(InputSettings settings)`

Writes the input settings to the player prefs.

**Parameters:**

* `settings`: The input settings to write.

### `ReadInputSettings()`

Reads the input settings from the player prefs.

**Returns:** `InputSettings`

### `GetActionControlPath(string actionName)`

Gets the control path for an action.

**Parameters:**

* `actionName`: The name of the action to get the control path for.

**Returns:** `string`
