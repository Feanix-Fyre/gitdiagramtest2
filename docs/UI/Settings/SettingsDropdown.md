# SettingsDropdown

The `SettingsDropdown` class is a base class for settings dropdowns. It gets a reference to the `TMP_Dropdown` component and registers a listener for the `onValueChanged` event. It also has a method for adding options to the dropdown.

## Public Properties

| Property         | Type     | Description                                      |
| ---------------- | -------- | ------------------------------------------------ |
| `DefaultOptions` | `string[]` | The default options for the dropdown.            |

## Protected Properties

| Property   | Type           | Description                                      |
| ---------- | -------------- | ------------------------------------------------ |
| `dropdown` | `TMP_Dropdown` | The `TMP_Dropdown` component for this setting.   |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `Awake()`            | `void`      | Initializes the component.                       |
| `OnValueChanged(int value)` | `void` | Called when the value of the dropdown changes.   |
| `AddOption(string option)` | `void` | Adds an option to the dropdown.                  |
