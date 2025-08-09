# MixingStationCanvas

The `MixingStationCanvas` class is a singleton that manages the UI for a mixing station.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `RecipeEntryPrefab`     | `StationRecipeEntry`      | The prefab for the recipe entries.               |
| `Canvas`                | `Canvas`                  | The canvas for the UI.                           |
| `Container`             | `RectTransform`           | The container for the UI elements.               |
| `ProductSlotUI`         | `ItemSlotUI`              | The UI for the product slot.                     |
| `ProductPropertiesLabel`| `TextMeshProUGUI`         | The label for the product's properties.          |
| `IngredientSlotUI`      | `ItemSlotUI`              | The UI for the ingredient slot.                  |
| `IngredientProblemLabel`| `TextMeshProUGUI`         | The label for when there is a problem with the ingredient. |
| `PreviewSlotUI`         | `ItemSlotUI`              | The UI for the preview slot.                     |
| `PreviewIcon`           | `Image`                   | The icon for the preview.                        |
| `PreviewLabel`          | `TextMeshProUGUI`         | The label for the preview.                       |
| `UnknownOutputIcon`     | `RectTransform`           | The icon to show when the output is unknown.     |
| `PreviewPropertiesLabel`| `TextMeshProUGI`          | The label for the preview's properties.          |
| `OutputSlotUI`          | `ItemSlotUI`              | The UI for the output slot.                      |
| `InstructionLabel`      | `TextMeshProUGUI`         | The label for the instructions.                  |
| `TitleContainer`        | `RectTransform`           | The container for the title.                     |
| `MainContainer`         | `RectTransform`           | The main container for the UI.                   |
| `BeginButton`           | `Button`                  | The button to begin the mixing process.          |
| `ProductHint`           | `RectTransform`           | The hint for the product slot.                   |
| `MixerHint`             | `RectTransform`           | The hint for the mixer slot.                     |
| `isOpen`                | `bool`                    | A boolean that indicates whether the UI is open. |
| `MixingStation`         | `MixingStation`           | The `MixingStation` that this UI belongs to.   |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Open(MixingStation station)`               | `void`      | Opens the UI.                                    |
| `Close(bool enablePlayerControl = true)`    | `void`      | Closes the UI.                                   |
| `BeginButtonPressed()`                      | `void`      | Called when the begin button is pressed.         |
| `StartMixOperation(MixOperation mixOperation)` | `void`    | Starts a mixing operation.                       |
