# ShopListing

The `ShopListing` class represents a listing in a shop. It contains information about the item being sold, its price, stock, and other settings. It also has methods for managing the stock and checking if the listing should be shown to the player.

## Classes

### CategoryInstance

This class is a data container for a shop category.

-   `Category`: The `EShopCategory` of the category.

## Enums

### ERestockRate

This enum defines the different restock rates for a listing.

-   `Daily`: The listing will be restocked daily.
-   `Weekly`: The listing will be restocked weekly.
-   `Never`: The listing will never be restocked.

## Public Properties

| Property                        | Type                   | Description                                                                  |
| ------------------------------- | ---------------------- | ---------------------------------------------------------------------------- |
| `name`                          | `string`               | The name of the listing.                                                     |
| `Item`                          | `StorableItemDefinition`| The item being sold.                                                         |
| `LimitedStock`                  | `bool`                 | A boolean that indicates whether the listing has limited stock.              |
| `DefaultStock`                  | `int`                  | The default stock of the listing.                                            |
| `RestockRate`                   | `ERestockRate`         | The restock rate of the listing.                                             |
| `EnforceMinimumGameCreationVersion` | `bool` | A boolean that indicates whether the listing should only be shown if the game creation version is greater than or equal to `MinimumGameCreationVersion`. |
| `MinimumGameCreationVersion`    | `float`                | The minimum game creation version required to show the listing.              |
| `CanBeDelivered`                | `bool`                 | A boolean that indicates whether the item can be delivered.                  |
| `UseIconTint`                   | `bool`                 | A boolean that indicates whether the item's icon should be tinted.           |
| `IconTint`                      | `Color`                | The color to tint the item's icon.                                           |
| `onStockChanged`                | `Action`               | An event that is invoked when the stock of the listing changes.              |
| `IsInStock`                     | `bool`                 | A boolean that indicates whether the listing is in stock.                    |
| `Price`                         | `float`                | The price of the item.                                                       |
| `IsUnlimitedStock`              | `bool`                 | A boolean that indicates whether the listing has unlimited stock.            |
| `Shop`                          | `ShopInterface`        | The `ShopInterface` that this listing belongs to.                            |
| `CurrentStock`                  | `int`                  | The current stock of the listing.                                            |
| `QuantityInCart`                | `int`                  | The quantity of the item in the cart.                                        |
| `CurrentStockMinusCart`         | `int`                  | The current stock of the listing minus the quantity in the cart.             |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Initialize(ShopInterface shop)`            | `void`      | Initializes the listing.                         |
| `Restock(bool network)`                     | `void`      | Restocks the listing.                            |
| `RemoveStock(int quantity)`                 | `void`      | Removes stock from the listing.                  |
| `SetStock(int quantity, bool network = true)` | `void`      | Sets the stock of the listing.                   |
| `ShouldShow()`                              | `bool`      | Checks if the listing should be shown to the player. |
| `DoesListingMatchCategoryFilter(EShopCategory category)` | `bool` | Checks if the listing matches a category filter. |
| `DoesListingMatchSearchTerm(string searchTerm)` | `bool` | Checks if the listing matches a search term. |
| `SetQuantityInCart(int quantity)`           | `void`      | Sets the quantity of the item in the cart.       |
