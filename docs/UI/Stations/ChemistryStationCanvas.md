# ChemistryStationCanvas

The `ChemistryStationCanvas` class is a singleton that manages the UI for a chemistry station.

## Public Properties

| Property                   | Type                      | Description                                      |
| -------------------------- | ------------------------- | ------------------------------------------------ |
| `Recipes`                  | `List<StationRecipe>`     | A list of all the recipes for this station.      |
| `RecipeEntryPrefab`        | `StationRecipeEntry`      | The prefab for the recipe entries.               |
| `Canvas`                   | `Canvas`                  | The canvas for the UI.                           |
| `Container`                | `RectTransform`           | The container for the UI elements.               |
| `InputSlotsContainer`      | `RectTransform`           | The container for the input slots.               |
| `InputSlotUIs`             | `ItemSlotUI[]`            | An array of UIs for the input slots.             |
| `OutputSlotUI`             | `ItemSlotUI`              | The UI for the output slot.                      |
| `RecipeSelectionContainer` | `RectTransform`           | The container for the recipe selection.          |
| `InstructionLabel`         | `TextMeshProUGUI`         | The label for the instructions.                  |
| `BeginButton`              | `Button`                  | The button to begin the cooking process.         |
| `SelectionIndicator`       | `RectTransform`           | The indicator for the selected recipe.           |
| `RecipeContainer`          | `RectTransform`           | The container for the recipe entries.            |
| `CookingInProgressContainer` | `RectTransform`         | The container for the cooking in progress UI.    |
| `InProgressRecipeEntry`    | `StationRecipeEntry`      | The recipe entry for the cooking in progress UI. |
| `InProgressLabel`          | `TextMeshProUGUI`         | The label for the cooking in progress UI.        |
| `ErrorLabel`               | `TextMeshProUGUI`         | The label for error messages.                    |
| `isOpen`                   | `bool`                    | A boolean that indicates whether the UI is open. |
| `ChemistryStation`         | `ChemistryStation`        | The `ChemistryStation` that this UI belongs to.|

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Open(ChemistryStation station)`            | `void`      | Opens the UI.                                    |
| `Close(bool removeUI)`                      | `void`      | Closes the UI.                                   |
| `BeginButtonPressed()`                      | `void`      | Called when the begin button is pressed.         |
