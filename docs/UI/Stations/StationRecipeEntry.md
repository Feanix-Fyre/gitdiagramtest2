# StationRecipeEntry

The `StationRecipeEntry` class is the UI for a single recipe in a station's recipe list. It displays the recipe's icon, title, cooking time, and ingredients. It also has a button that can be used to start the recipe, which is only interactable if the player has the required ingredients.

## Public Properties

| Property           | Type                | Description                                      |
| ------------------ | ------------------- | ------------------------------------------------ |
| `ValidColor`       | `Color`             | The color to use for the ingredient quantities when the player has enough of the ingredient. |
| `InvalidColor`     | `Color`             | The color to use for the ingredient quantities when the player does not have enough of the ingredient. |
| `Button`           | `Button`            | The button to start the recipe.                  |
| `Icon`             | `Image`             | The icon for the recipe's product.               |
| `TitleLabel`       | `TextMeshProUGUI`   | The label for the recipe's title.                |
| `CookingTimeLabel` | `TextMeshProUGUI`   | The label for the recipe's cooking time.         |
| `IngredientRects`  | `RectTransform[]`   | An array of `RectTransform`s for the ingredients. |
| `IsValid`          | `bool`              | A boolean that indicates whether the recipe is valid (i.e., the player has the required ingredients). |
| `Recipe`           | `StationRecipe`     | The `StationRecipe` that this UI represents.     |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `AssignRecipe(StationRecipe recipe)`        | `void`      | Assigns a recipe to this UI.                     |
| `RefreshValidity(List<ItemInstance> ingredients)` | `void` | Refreshes the validity of the recipe based on the player's ingredients. |
| `GetIngredientsMatchDelta(List<ItemInstance> ingredients)` | `float` | Gets a value from 0 to 1 that indicates how well the player's ingredients match the recipe's ingredients. |
