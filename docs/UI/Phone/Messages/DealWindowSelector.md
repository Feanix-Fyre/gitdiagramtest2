# DealWindowSelector

The `DealWindowSelector` class is the UI for the deal window selector in the phone's messaging app. It allows the player to select a time window for a deal.

## Public Constants

| Constant               | Type  | Description                                      |
| ---------------------- | ----- | ------------------------------------------------ |
| `TIME_ARM_ROTATION_0000` | `float` | The rotation of the time arm at 00:00.           |
| `TIME_ARM_ROTATION_2400` | `float` | The rotation of the time arm at 24:00.           |
| `WINDOW_CUTOFF_MINS`   | `int` | The number of minutes before a window becomes invalid. |

## Public Properties

| Property            | Type                       | Description                                      |
| ------------------- | -------------------------- | ------------------------------------------------ |
| `OnSelected`        | `UnityEvent<EDealWindow>`  | An event that is invoked when a window is selected. |
| `Container`         | `GameObject`               | The container for the UI elements.               |
| `MorningButton`     | `WindowSelectorButton`     | The button for the morning window.               |
| `AfternoonButton`   | `WindowSelectorButton`     | The button for the afternoon window.             |
| `NightButton`       | `WindowSelectorButton`     | The button for the night window.                 |
| `LateNightButton`   | `WindowSelectorButton`     | The button for the late night window.            |
| `CurrentTimeArm`    | `RectTransform`            | The transform for the current time arm.          |
| `CurrentTimeLabel`  | `Text`                     | The label for the current time.                  |
| `IsOpen`            | `bool`                     | A boolean that indicates whether the selector is open. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Exit(ExitAction action)`                   | `void`      | Called when the player exits the selector.       |
| `SetIsOpen(bool open)`                      | `void`      | Opens or closes the selector.                    |
| `SetIsOpen(bool open, MSGConversation conversation, Action<EDealWindow> callback = null)` | `void` | Opens or closes the selector for a specific conversation. |
| `Update()`                                  | `void`      | Updates the selector.                            |
