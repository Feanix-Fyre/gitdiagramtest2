# DeliveryStatusDisplay

The `DeliveryStatusDisplay` class is the UI for displaying the status of a delivery.

## Public Properties

| Property              | Type                  | Description                                      |
| --------------------- | --------------------- | ------------------------------------------------ |
| `ItemEntryPrefab`     | `GameObject`          | The prefab for the item entries.                 |
| `Rect`                | `RectTransform`       | The `RectTransform` of the UI.                   |
| `DestinationLabel`    | `Text`                | The label for the destination.                   |
| `ShopLabel`           | `Text`                | The label for the shop.                          |
| `StatusImage`         | `Image`               | The image for the status.                        |
| `StatusLabel`         | `Text`                | The label for the status.                        |
| `StatusTooltip`       | `Tooltip`             | The tooltip for the status.                      |
| `ItemEntryContainer`  | `RectTransform`       | The container for the item entries.              |
| `StatusColor_Transit` | `Color`               | The color to use for the "In Transit" status.    |
| `StatusColor_Waiting` | `Color`               | The color to use for the "Waiting" status.       |
| `StatusColor_Arrived` | `Color`               | The color to use for the "Arrived" status.       |
| `DeliveryInstance`    | `DeliveryInstance`    | The `DeliveryInstance` that this UI represents.|

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `AssignDelivery(DeliveryInstance instance)` | `void`      | Assigns a delivery to this UI.                   |
| `RefreshStatus()`                           | `void`      | Refreshes the status of the delivery.            |
