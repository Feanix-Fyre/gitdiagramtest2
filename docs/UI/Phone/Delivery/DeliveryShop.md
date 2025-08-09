# DeliveryShop

The `DeliveryShop` class is the UI for a delivery shop in the phone app. It displays a list of items that can be delivered, and it allows the player to place an order for delivery.

## Public Constants

| Constant                         | Type | Description                                      |
| -------------------------------- | ---- | ------------------------------------------------ |
| `DELIVERY_VEHICLE_SLOT_CAPACITY`   | `int`| The slot capacity of the delivery vehicle.       |
| `DELIVERY_TIME_MIN`              | `int`| The minimum delivery time in minutes.            |
| `DELIVERY_TIME_MAX`              | `int`| The maximum delivery time in minutes.            |
| `DELIVERY_TIME_ITEM_COUNT_DIVISOR` | `int`| The divisor for the item count when calculating the delivery time. |

## Public Properties

| Property                    | Type            | Description                                      |
| --------------------------- | --------------- | ------------------------------------------------ |
| `HeaderImage`               | `Image`         | The image for the header.                        |
| `HeaderButton`              | `Button`        | The button for the header.                       |
| `ContentsContainer`         | `RectTransform` | The container for the contents.                  |
| `ListingContainer`          | `RectTransform` | The container for the listings.                  |
| `DeliveryFeeLabel`          | `Text`          | The label for the delivery fee.                  |
| `ItemTotalLabel`            | `Text`          | The label for the item total.                    |
| `OrderTotalLabel`           | `Text`          | The label for the order total.                   |
| `OrderButton`               | `Button`        | The button to place the order.                   |
| `OrderButtonNote`           | `Text`          | The note for the order button.                   |
| `DestinationDropdown`       | `Dropdown`      | The dropdown for the destination.                |
| `LoadingDockDropdown`       | `Dropdown`      | The dropdown for the loading dock.               |
| `MatchingShopInterfaceName` | `string`        | The name of the matching shop interface.         |
| `DeliveryFee`               | `float`         | The delivery fee.                                |
| `AvailableByDefault`        | `bool`          | A boolean that indicates whether the shop is available by default. |
| `ListingEntryPrefab`        | `ListingEntry`  | The prefab for the listing entries.              |
| `HeaderImage_Hidden`        | `Sprite`        | The sprite for the header when it is hidden.     |
| `HeaderImage_Expanded`      | `Sprite`        | The sprite for the header when it is expanded.   |
| `HeaderArrow`               | `RectTransform` | The transform for the header arrow.              |
| `MatchingShop`              | `ShopInterface` | The `ShopInterface` that this shop is matched with. |
| `IsExpanded`                | `bool`          | A boolean that indicates whether the shop is expanded. |
| `IsAvailable`               | `bool`          | A boolean that indicates whether the shop is available. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `SetIsExpanded(bool expanded)`              | `void`      | Sets whether the shop is expanded.               |
| `SetIsAvailable()`                          | `void`      | Sets the shop as available.                      |
| `OrderPressed()`                            | `void`      | Called when the order button is pressed.         |
| `RefreshShop()`                             | `void`      | Refreshes the shop.                              |
| `ResetCart()`                               | `void`      | Resets the cart.                                 |
| `CanOrder(out string reason)`               | `bool`      | Checks if the player can place an order.         |
| `HasActiveDelivery()`                       | `bool`      | Checks if there is an active delivery.           |
| `WillCartFitInVehicle()`                    | `bool`      | Checks if the cart will fit in the delivery vehicle. |
| `RefreshDestinationUI()`                    | `void`      | Refreshes the destination UI.                    |
| `RefreshLoadingDockUI()`                    | `void`      | Refreshes the loading dock UI.                   |
