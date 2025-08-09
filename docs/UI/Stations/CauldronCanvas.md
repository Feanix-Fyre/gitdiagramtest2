# CauldronCanvas

The `CauldronCanvas` class is a singleton that manages the UI for a cauldron.

## Public Properties

| Property           | Type                | Description                                      |
| ------------------ | ------------------- | ------------------------------------------------ |
| `Canvas`           | `Canvas`            | The canvas for the UI.                           |
| `Container`        | `GameObject`        | The container for the UI elements.               |
| `IngredientSlotUIs`| `List<ItemSlotUI>`  | A list of UIs for the ingredient slots.          |
| `LiquidSlotUI`     | `ItemSlotUI`        | The UI for the liquid slot.                      |
| `OutputSlotUI`     | `ItemSlotUI`        | The UI for the output slot.                      |
| `InstructionLabel` | `TextMeshProUGUI`   | The label for the instructions.                  |
| `BeginButton`      | `Button`            | The button to begin the cooking process.         |
| `isOpen`           | `bool`              | A boolean that indicates whether the UI is open. |
| `Cauldron`         | `Cauldron`          | The `Cauldron` that this UI belongs to.        |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetIsOpen(Cauldron cauldron, bool open, bool removeUI = true)` | `void` | Opens or closes the UI.                          |
| `BeginButtonPressed()`                      | `void`      | Called when the begin button is pressed.         |
