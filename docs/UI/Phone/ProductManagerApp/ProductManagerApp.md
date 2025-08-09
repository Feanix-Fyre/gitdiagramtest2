# ProductManagerApp

The `ProductManagerApp` class is the UI for the product manager app on the phone. It displays a list of all the discovered products, as well as a list of the player's favorite products. It also has a detail panel that shows information about the selected product.

## Classes

### ProductTypeContainer

This class is a container for the UI elements of a single product type.

-   `DrugType`: The `EDrugType` of the product.
-   `Container`: The `RectTransform` for the container.
-   `NoneDisplay`: The `RectTransform` to display when there are no products of this type.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `FavouritesContainer`   | `ProductTypeContainer`    | The container for the favorite products.         |
| `ProductTypeContainers` | `List<ProductTypeContainer>` | A list of all the product type containers.       |
| `DetailPanel`           | `ProductAppDetailPanel`   | The detail panel for the selected product.       |
| `SelectionIndicator`    | `RectTransform`           | The indicator for the selected product.          |
| `EntryPrefab`           | `GameObject`              | The prefab for the product entries.              |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `CreateEntry(ProductDefinition definition)` | `void`      | Creates a new entry for a product.               |
| `SelectProduct(ProductEntry entry)`         | `void`      | Selects a product.                               |
| `SetOpen(bool open)`                        | `void`      | Opens or closes the app.                         |
