# BrickPressCanvas

The `BrickPressCanvas` class is a singleton that manages the UI for a brick press.

## Public Properties

| Property           | Type                | Description                                      |
| ------------------ | ------------------- | ------------------------------------------------ |
| `Canvas`           | `Canvas`            | The canvas for the UI.                           |
| `Container`        | `RectTransform`     | The container for the UI elements.               |
| `ProductSlotUIs`   | `ItemSlotUI[]`      | An array of UIs for the product slots.           |
| `OutputSlotUI`     | `ItemSlotUI`        | The UI for the output slot.                      |
| `InstructionLabel` | `TextMeshProUGUI`   | The label for the instructions.                  |
| `BeginButton`      | `Button`            | The button to begin the pressing process.        |
| `isOpen`           | `bool`              | A boolean that indicates whether the UI is open. |
| `Press`            | `BrickPress`        | The `BrickPress` that this UI belongs to.      |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetIsOpen(BrickPress press, bool open, bool removeUI = true)` | `void` | Opens or closes the UI.                          |
| `BeginButtonPressed()`                      | `void`      | Called when the begin button is pressed.         |
