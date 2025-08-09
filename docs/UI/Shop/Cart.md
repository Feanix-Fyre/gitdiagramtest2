# Cart

The `Cart` class manages the shopping cart for a shop.

## Public Properties

| Property               | Type                            | Description                                      |
| ---------------------- | ------------------------------- | ------------------------------------------------ |
| `Shop`                 | `ShopInterface`                 | The `ShopInterface` that this cart belongs to.   |
| `CartIcon`             | `Image`                         | The icon for the cart.                           |
| `ViewCartText`         | `TextMeshProUGUI`               | The text for the view cart button.               |
| `CartEntryContainer`   | `RectTransform`                 | The container for the cart entries.              |
| `ProblemText`          | `TextMeshProUGUI`               | The text for when there is a problem with the cart. |
| `WarningText`          | `TextMeshProUGUI`               | The text for when there is a warning with the cart. |
| `BuyButton`            | `Button`                        | The button to buy the items in the cart.         |
| `CartContainer`        | `RectTransform`                 | The container for the cart UI.                   |
| `CartArea`             | `Image`                         | The background image for the cart.               |
| `TotalText`            | `TextMeshProUGUI`               | The text for the total price of the items in the cart. |
| `LoadVehicleToggle`    | `Toggle`                        | The toggle for loading the items into a vehicle. |
| `EntryPrefab`          | `CartEntry`                     | The prefab for the cart entries.                 |
| `cartDictionary`       | `Dictionary<ShopListing, int>`  | A dictionary of the items in the cart.           |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `AddItem(ShopListing listing, int quantity)`| `void`      | Adds an item to the cart.                        |
| `RemoveItem(ShopListing listing, int quantity)` | `void`    | Removes an item from the cart.                   |
| `ClearCart()`                               | `void`      | Clears the cart.                                 |
| `GetCartCount(ShopListing listing)`         | `int`       | Gets the quantity of an item in the cart.        |
| `BopCartIcon()`                             | `void`      | Bops the cart icon.                              |
| `CanPlayerAffordCart()`                     | `bool`      | Checks if the player can afford the items in the cart. |
| `Buy()`                                     | `void`      | Buys the items in the cart.                      |
| `GetTotalSlotRequirement()`                 | `int`       | Gets the total number of slots required for the items in the cart. |
