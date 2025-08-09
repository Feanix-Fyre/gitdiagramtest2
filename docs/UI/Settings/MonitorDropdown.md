# MonitorDropdown

The `MonitorDropdown` class inherits from `SettingsDropdown` and is used to control the monitor setting.

## Public Methods

| Method                  | Return Type | Description                                      |
| ----------------------- | ----------- | ------------------------------------------------ |
| `GetCurrentDisplayNumber()` | `int`       | Gets the index of the current display.           |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `Awake()`            | `void`      | Initializes the component.                       |
| `OnEnable()`         | `void`      | Called when the object becomes enabled and active. |
| `OnValueChanged(int value)` | `void` | Called when the value of the dropdown changes.   |
