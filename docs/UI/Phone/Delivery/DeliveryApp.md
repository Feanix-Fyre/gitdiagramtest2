# DeliveryApp

The `DeliveryApp` class is the UI for the delivery app on the phone. It displays a list of delivery shops and a list of the player's active deliveries.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `StatusDisplayPrefab`   | `DeliveryStatusDisplay`   | The prefab for the delivery status display.      |
| `OrderSubmittedAnim`    | `Animation`               | The animation to play when an order is submitted. |
| `OrderSubmittedSound`   | `AudioSourceController`   | The sound to play when an order is submitted.    |
| `StatusDisplayContainer`| `RectTransform`           | The container for the delivery status displays.  |
| `NoDeliveriesIndicator` | `RectTransform`           | The indicator to show when there are no active deliveries. |
| `MainScrollRect`        | `ScrollRect`              | The main scroll rect for the app.                |
| `MainLayoutGroup`       | `LayoutGroup`             | The main layout group for the app.               |

## Public Methods

| Method                                      | Return Type     | Description                                      |
| ------------------------------------------- | --------------- | ------------------------------------------------ |
| `SetOpen(bool open)`                        | `void`          | Opens or closes the app.                         |
| `RefreshContent(bool keepScrollPosition = true)` | `void` | Refreshes the content of the app.                |
| `PlayOrderSubmittedAnim()`                  | `void`          | Plays the order submitted animation.             |
| `RefreshLayoutGroupsImmediateAndRecursive(GameObject root)` | `void` | Refreshes the layout groups of a game object and its children. |
| `GetShop(ShopInterface matchingShop)`       | `DeliveryShop`  | Gets a delivery shop by its matching shop interface. |
| `GetShop(string shopName)`                  | `DeliveryShop`  | Gets a delivery shop by its name.                |
