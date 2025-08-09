# IntefaceScaleSlider

The `IntefaceScaleSlider` class inherits from `SettingsSlider` and is used to control the UI scale setting.

## Public Constants

| Constant   | Type  | Description                                      |
| ---------- | ----- | ------------------------------------------------ |
| `MULTIPLIER` | `float` | A multiplier for the UI scale value.             |
| `MinScale` | `float` | The minimum UI scale.                            |
| `MaxScale` | `float` | The maximum UI scale.                            |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `OnEnable()`         | `void`      | Called when the object becomes enabled and active. |
| `OnValueChanged(float value)` | `void` | Called when the value of the slider changes.     |
| `GetDisplayValue(float value)` | `string` | Gets the string representation of the slider's value. |
