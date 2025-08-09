# ConfirmDisplaySettings

The `ConfirmDisplaySettings` class is the UI for confirming display settings. It has a countdown timer, and if the player does not confirm the new settings within the time limit, the settings will be reverted.

## Public Constants

| Constant     | Type  | Description                                      |
| ------------ | ----- | ------------------------------------------------ |
| `RevertTime` | `float` | The time in seconds before the settings are reverted. |

## Public Properties

| Property        | Type              | Description                                      |
| --------------- | ----------------- | ------------------------------------------------ |
| `SubtitleLabel` | `TextMeshProUGUI` | The label for the countdown timer.               |
| `IsOpen`        | `bool`            | A boolean that indicates whether the confirmation window is open. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Awake()`                                   | `void`      | Initializes the component.                       |
| `Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)` | `void` | Opens the confirmation window.                   |
| `Exit(ExitAction action)`                   | `void`      | Called when the player exits the confirmation window. |
| `Update()`                                  | `void`      | Updates the countdown timer.                     |
| `Close(bool revert)`                        | `void`      | Closes the confirmation window.                  |
