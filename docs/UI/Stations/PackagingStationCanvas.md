# PackagingStationCanvas

The `PackagingStationCanvas` class is a singleton that manages the UI for a packaging station.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `ShowHintOnOpen`        | `bool`                    | If true, a hint will be shown when the UI is opened. |
| `ShowShiftClickHint`    | `bool`                    | If true, a hint will be shown for shift-clicking. |
| `CurrentMode`           | `PackagingStation.EMode`  | The current mode of the packaging station.       |
| `InstructionWarningColor`| `Color`                  | The color to use for warning messages.           |
| `Canvas`                | `Canvas`                  | The canvas for the UI.                           |
| `Container`             | `GameObject`              | The container for the UI elements.               |
| `PackagingSlotUI`       | `ItemSlotUI`              | The UI for the packaging slot.                   |
| `ProductSlotUI`         | `ItemSlotUI`              | The UI for the product slot.                     |
| `OutputSlotUI`          | `ItemSlotUI`              | The UI for the output slot.                      |
| `InstructionLabel`      | `TextMeshProUGUI`         | The label for the instructions.                  |
| `InstructionShadow`     | `Image`                   | The shadow for the instruction label.            |
| `BeginButton`           | `Button`                  | The button to begin the packaging process.       |
| `ModeAnimation`         | `Animation`               | The animation for switching modes.               |
| `ButtonLabel`           | `TextMeshProUGUI`         | The label for the begin button.                  |
| `isOpen`                | `bool`                    | A boolean that indicates whether the UI is open. |
| `PackagingStation`      | `PackagingStation`        | The `PackagingStation` that this UI belongs to.  |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetIsOpen(PackagingStation station, bool open, bool removeUI = true)` | `void` | Opens or closes the UI.                          |
| `BeginButtonPressed()`                      | `void`      | Called when the begin button is pressed.         |
| `ToggleMode()`                              | `void`      | Toggles the mode of the packaging station.       |
| `SetMode(PackagingStation.EMode mode)`      | `void`      | Sets the mode of the packaging station.          |
