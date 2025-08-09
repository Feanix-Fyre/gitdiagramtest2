# LabOvenCanvas

The `LabOvenCanvas` class is a singleton that manages the UI for a lab oven.

## Public Properties

| Property           | Type              | Description                                      |
| ------------------ | ----------------- | ------------------------------------------------ |
| `Canvas`           | `Canvas`          | The canvas for the UI.                           |
| `Container`        | `GameObject`      | The container for the UI elements.               |
| `IngredientSlotUI` | `ItemSlotUI`      | The UI for the ingredient slot.                  |
| `OutputSlotUI`     | `ItemSlotUI`      | The UI for the output slot.                      |
| `InstructionLabel` | `TextMeshProUGUI` | The label for the instructions.                  |
| `ErrorLabel`       | `TextMeshProUGUI` | The label for error messages.                    |
| `BeginButton`      | `Button`          | The button to begin the cooking process.         |
| `BeginButtonLabel` | `TextMeshProUGUI` | The label for the begin button.                  |
| `ProgressContainer`| `RectTransform`   | The container for the progress bar.              |
| `IngredientIcon`   | `Image`           | The icon for the ingredient.                     |
| `ProgressImg`      | `Image`           | The image for the progress bar.                  |
| `ProductIcon`      | `Image`           | The icon for the product.                        |
| `isOpen`           | `bool`            | A boolean that indicates whether the UI is open. |
| `Oven`             | `LabOven`         | The `LabOven` that this UI belongs to.         |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetIsOpen(LabOven oven, bool open, bool removeUI = true)` | `void` | Opens or closes the UI.                          |
| `BeginButtonPressed()`                      | `void`      | Called when the begin button is pressed.         |
| `CanBegin()`                                | `bool`      | Checks if the cooking process can begin.         |
