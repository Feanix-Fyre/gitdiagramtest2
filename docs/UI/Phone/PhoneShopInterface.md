# PhoneShopInterface

The `PhoneShopInterface` class is the UI for a shop that is accessed through the phone. It displays a list of items that can be purchased, and it allows the player to add items to a cart and place an order.

## Classes

### Listing

This class is a data container for a single listing in the shop.

-   `Item`: The `ItemDefinition` of the item.
-   `Price`: The price of the item.

### CartEntry

This class is a data container for a single entry in the cart.

-   `Listing`: The `Listing` for the entry.
-   `Quantity`: The quantity of the item in the cart.

## Public Properties

| Property            | Type                       | Description                                      |
| ------------------- | -------------------------- | ------------------------------------------------ |
| `EntryPrefab`       | `RectTransform`            | The prefab for the listing entries.              |
| `ValidAmountColor`  | `Color`                    | The color to use for the order total when it is valid. |
| `InvalidAmountColor`| `Color`                    | The color to use for the order total when it is invalid. |
| `Container`         | `GameObject`               | The container for the UI elements.               |
| `TitleLabel`        | `Text`                     | The label for the title.                         |
| `SubtitleLabel`     | `Text`                     | The label for the subtitle.                      |
| `EntryContainer`    | `RectTransform`            | The container for the listing entries.           |
| `OrderTotalLabel`   | `Text`                     | The label for the order total.                   |
| `OrderLimitLabel`   | `Text`                     | The label for the order limit.                   |
| `DebtLabel`         | `Text`                     | The label for the debt.                          |
| `ConfirmButton`     | `Button`                   | The button to confirm the order.                 |
| `ItemLimitContainer`| `GameObject`               | The container for the item limit.                |
| `ItemLimitLabel`    | `Text`                     | The label for the item limit.                    |
| `IsOpen`            | `bool`                     | A boolean that indicates whether the shop is open. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `Open(string title, string subtitle, MSGConversation _conversation, List<Listing> listings, float _orderLimit, float debt, Action<List<CartEntry>, float> _orderConfirmedCallback)` | `void` | Opens the shop. |
| `Close()`                                   | `void`      | Closes the shop.                                 |
| `Exit(ExitAction action)`                   | `void`      | Called when the player exits the shop.           |
