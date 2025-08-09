# SensitivitySlider

The `SensitivitySlider` class inherits from `SettingsSlider` and is used to control the mouse sensitivity setting.

## Public Constants

| Constant   | Type  | Description                                      |
| ---------- | ----- | ------------------------------------------------ |
| `MULTIPLIER` | `float` | A multiplier for the sensitivity value.          |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `Start()`            | `void`      | Called when the component is started.            |
| `OnValueChanged(float value)` | `void` | Called when the value of the slider changes.     |
