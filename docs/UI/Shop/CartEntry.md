# CartEntry

The `CartEntry` class is the UI for a single entry in the cart. It displays the item's name, price, and quantity, and it has buttons for incrementing, decrementing, and removing the item from the cart.

## Public Properties

| Property          | Type              | Description                                      |
| ----------------- | ----------------- | ------------------------------------------------ |
| `NameLabel`       | `TextMeshProUGUI` | The label for the item's name.                   |
| `PriceLabel`      | `TextMeshProUGUI` | The label for the item's price.                  |
| `IncrementButton` | `Button`          | The button to increment the quantity of the item. |
| `DecrementButton` | `Button`          | The button to decrement the quantity of the item. |
| `RemoveButton`    | `Button`          | The button to remove the item from the cart.     |
| `Quantity`        | `int`             | The quantity of the item in the cart.            |
| `Cart`            | `Cart`            | The `Cart` that this entry belongs to.           |
| `Listing`         | `ShopListing`     | The `ShopListing` for this entry.                |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Initialize(Cart cart, ShopListing listing, int quantity)` | `void` | Initializes the cart entry.                      |
| `SetQuantity(int quantity)`                 | `void`      | Sets the quantity of the item in the cart.       |

## Protected Methods

| Method        | Return Type | Description                                      |
| ------------- | ----------- | ------------------------------------------------ |
| `UpdateTitle()` | `void`      | Updates the title of the cart entry.             |
