# ListingEntry

The `ListingEntry` class is the UI for a single listing in the delivery app. It displays the item's icon, name, and price, and it has an input field for the quantity.

## Public Properties

| Property            | Type              | Description                                      |
| ------------------- | ----------------- | ------------------------------------------------ |
| `Icon`              | `Image`           | The icon for the item.                           |
| `ItemNameLabel`     | `Text`            | The label for the item's name.                   |
| `ItemPriceLabel`    | `Text`            | The label for the item's price.                  |
| `QuantityInput`     | `InputField`      | The input field for the quantity.                |
| `IncrementButton`   | `Button`          | The button to increment the quantity.            |
| `DecrementButton`   | `Button`          | The button to decrement the quantity.            |
| `LockedContainer`   | `RectTransform`   | The container for the locked icon.               |
| `onQuantityChanged` | `UnityEvent`      | An event that is invoked when the quantity changes. |
| `MatchingListing`   | `ShopListing`     | The `ShopListing` that this entry represents.    |
| `SelectedQuantity`  | `int`             | The selected quantity.                           |

## Public Methods

| Method                             | Return Type | Description                                      |
| ---------------------------------- | ----------- | ------------------------------------------------ |
| `Initialize(ShopListing match)`    | `void`      | Initializes the entry with a shop listing.       |
| `RefreshLocked()`                  | `void`      | Refreshes the locked state of the entry.         |
| `SetQuantity(int quant, bool notify = true)` | `void` | Sets the quantity of the item.                   |
