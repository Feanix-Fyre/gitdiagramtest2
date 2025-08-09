# StationRecipe

The `StationRecipe` class is a scriptable object that represents a recipe for a station.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `IsDiscovered` | `bool` | If `true`, the recipe has been discovered. |
| `RecipeTitle` | `string` | The title of the recipe. |
| `Unlocked` | `bool` | If `true`, the recipe is unlocked. |
| `Ingredients` | `List<IngredientQuantity>` | A list of all ingredients in the recipe. |
| `Product` | `ItemQuantity` | The product of the recipe. |
| `FinalLiquidColor` | `Color` | The final color of the liquid. |
| `CookTime_Mins` | `int` | The time it takes to cook the recipe in minutes. |
| `CookTemperature` | `float` | The temperature at which the recipe should be cooked. |
| `CookTemperatureTolerance` | `float` | The tolerance for the cook temperature. |
| `QualityCalculationMethod` | `EQualityCalculationMethod` | The method for calculating the quality of the product. |
| `CookTemperatureLowerBound` | `float` | The lower bound of the cook temperature. |
| `CookTemperatureUpperBound` | `float` | The upper bound of the cook temperature. |
| `RecipeID` | `string` | The ID of the recipe. |

## Methods

### `GetProductInstance(List<ItemInstance> ingredients)`

Gets the product instance for the recipe.

**Parameters:**

* `ingredients`: The list of ingredients used to cook the recipe.

**Returns:** `StorableItemInstance`

### `GetProductInstance(EQuality quality)`

Gets the product instance for the recipe.

**Parameters:**

* `quality`: The quality of the product.

**Returns:** `StorableItemInstance`

### `DoIngredientsSuffice(List<ItemInstance> ingredients)`

Returns `true` if the given ingredients are sufficient for the recipe.

**Parameters:**

* `ingredients`: The list of ingredients to check.

**Returns:** `bool`

### `CalculateQuality(List<ItemInstance> ingredients)`

Calculates the quality of the product.

**Parameters:**

* `ingredients`: The list of ingredients used to cook the recipe.

**Returns:** `EQuality`
