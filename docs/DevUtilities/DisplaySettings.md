# DisplaySettings

The `DisplaySettings` struct is a serializable struct that contains settings for the display.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ResolutionIndex` | `int` | The index of the resolution in the list of available resolutions. |
| `DisplayMode` | `EDisplayMode` | The display mode. |
| `VSync` | `bool` | If `true`, VSync is enabled. |
| `TargetFPS` | `int` | The target frames per second. |
| `UIScale` | `float` | The scale of the UI. |
| `CameraBobbing` | `float` | The intensity of the camera bobbing. |
| `ActiveDisplayIndex` | `int` | The index of the active display. |

## Methods

### `GetResolutions()`

Gets a list of available resolutions.

**Returns:** `List<Resolution>`

---

# EDisplayMode

The `EDisplayMode` enum defines the different display modes.

## Values

| Name | Description |
| --- | --- |
| `Windowed` | The game is displayed in a window. |
| `FullscreenWindow` | The game is displayed in a fullscreen window. |
| `ExclusiveFullscreen` | The game is displayed in exclusive fullscreen mode. |
