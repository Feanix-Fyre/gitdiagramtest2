# DigitalAlarm

The `DigitalAlarm` class represents a digital alarm clock in the game. It is responsible for displaying the time and flashing the screen.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ScreenMesh` | `MeshRenderer` | The mesh renderer for the screen. |
| `ScreenMeshMaterialIndex` | `int` | The material index for the screen. |
| `ScreenText` | `TextMeshPro` | The text mesh pro for the screen. |
| `FlashScreen` | `bool` | If `true`, the screen will flash. |
| `DisplayCurrentTime` | `bool` | If `true`, the current time will be displayed on the screen. |
| `ScreenOffMat` | `Material` | The material for the screen when it is off. |
| `ScreenOnMat` | `Material` | The material for the screen when it is on. |

## Methods

### `SetScreenLit(bool lit)`

Sets whether the screen is lit.

**Parameters:**

* `lit`: If `true`, the screen will be lit.

### `DisplayText(string text)`

Displays text on the screen.

**Parameters:**

* `text`: The text to display.

### `DisplayMinutes(int mins)`

Displays the time in minutes on the screen.

**Parameters:**

* `mins`: The number of minutes to display.
