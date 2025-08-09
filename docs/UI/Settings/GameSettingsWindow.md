# GameSettingsWindow

The `GameSettingsWindow` class is the UI for the game settings window.

## Public Properties

| Property        | Type    | Description                                      |
| --------------- | ------- | ------------------------------------------------ |
| `ConsoleToggle` | `Toggle`| The toggle for enabling and disabling the console. |
| `Blocker`       | `GameObject` | The blocker to prevent interaction with the settings when not on the server. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Start()`                                   | `void`      | Initializes the component.                       |
| `ApplySettings(GameSettings settings)`      | `void`      | Applies the settings to the UI.                  |
