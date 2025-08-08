# InputSettings

The `InputSettings` class is a serializable class that contains settings for input.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `MouseSensitivity` | `float` | The sensitivity of the mouse. |
| `InvertMouse` | `bool` | If `true`, the mouse will be inverted. |
| `SprintMode` | `EActionMode` | The action mode for sprinting. |
| `BindingOverrides` | `string` | A string containing any binding overrides. |

---

# EActionMode

The `EActionMode` enum defines the different action modes for input.

## Values

| Name | Description |
| --- | --- |
| `Press` | The action is performed when the button is pressed. |
| `Hold` | The action is performed when the button is held down. |
