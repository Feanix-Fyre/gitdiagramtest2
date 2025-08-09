# SettingsToggle

The `SettingsToggle` class is a base class for settings toggles. It gets a reference to the `Toggle` component and registers a listener for the `onValueChanged` event.

## Protected Properties

| Property | Type   | Description                                      |
| -------- | ------ | ------------------------------------------------ |
| `toggle` | `Toggle` | The `Toggle` component for this setting.         |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `Awake()`            | `void`      | Initializes the component.                       |
| `OnValueChanged(bool value)` | `void` | Called when the value of the toggle changes.     |
