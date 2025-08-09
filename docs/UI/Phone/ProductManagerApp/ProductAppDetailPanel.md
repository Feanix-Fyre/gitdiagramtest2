# ProductAppDetailPanel

The `ProductAppDetailPanel` class is the UI for the detail panel in the product manager app. It displays information about a product, such as its name, description, properties, and recipes. It also has controls for setting the product's price and for listing it for sale.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `AddictionColor_Min`    | `Color`                   | The color to use for the addiction label when the addiction level is low. |
| `AddictionColor_Max`    | `Color`                   | The color to use for the addiction label when the addiction level is high. |
| `NothingSelected`       | `GameObject`              | The game object to display when no product is selected. |
| `Container`             | `GameObject`              | The container for the UI elements.               |
| `NameLabel`             | `Text`                    | The label for the product's name.                |
| `ValueLabel`            | `InputField`              | The input field for the product's price.         |
| `SuggestedPriceLabel`   | `TextMeshProUGUI`         | The label for the suggested price.               |
| `ListedForSale`         | `Toggle`                  | The toggle for listing the product for sale.     |
| `DescLabel`             | `Text`                    | The label for the product's description.         |
| `PropertyLabels`        | `Text[]`                  | An array of labels for the product's properties. |
| `Listed`                | `RectTransform`           | The transform for the "Listed" indicator.        |
| `Delisted`              | `RectTransform`           | The transform for the "Delisted" indicator.      |
| `NotDiscovered`         | `RectTransform`           | The transform for the "Not Discovered" indicator.|
| `RecipesLabel`          | `RectTransform`           | The label for the recipes.                       |
| `RecipeEntries`         | `RectTransform[]`         | An array of transforms for the recipe entries.   |
| `LayoutGroup`           | `VerticalLayoutGroup`     | The layout group for the UI.                     |
| `AddictionSlider`       | `Scrollbar`               | The scrollbar for the addiction level.           |
| `AddictionLabel`        | `Text`                    | The label for the addiction level.               |
| `ScrollRect`            | `ScrollRect`              | The scroll rect for the UI.                      |
| `ActiveProduct`         | `ProductDefinition`       | The currently active product.                    |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Awake()`                                   | `void`      | Initializes the component.                       |
| `SetActiveProduct(ProductDefinition productDefinition)` | `void` | Sets the active product.                         |
