# DealerManagementApp

The `DealerManagementApp` class is the UI for the dealer management app on the phone. It allows the player to view their dealers, see their stats, and assign customers to them.

## Public Properties

| Property               | Type            | Description                                      |
| ---------------------- | --------------- | ------------------------------------------------ |
| `NoDealersLabel`       | `Text`          | The label to display when there are no dealers.  |
| `Content`              | `RectTransform` | The container for the app's content.             |
| `CustomerSelector`     | `CustomerSelector` | The customer selector UI.                        |
| `SelectorImage`        | `Image`         | The image for the selected dealer.               |
| `SelectorTitle`        | `Text`          | The title for the selected dealer.               |
| `BackButton`           | `Button`        | The button to go to the previous dealer.         |
| `NextButton`           | `Button`        | The button to go to the next dealer.             |
| `CashLabel`            | `Text`          | The label for the dealer's cash.                 |
| `CutLabel`             | `Text`          | The label for the dealer's cut.                  |
| `HomeLabel`            | `Text`          | The label for the dealer's home.                 |
| `InventoryEntries`     | `RectTransform[]` | An array of `RectTransform`s for the inventory entries. |
| `CustomerTitleLabel`   | `Text`          | The label for the customer title.                |
| `CustomerEntries`      | `RectTransform[]` | An array of `RectTransform`s for the customer entries. |
| `AssignCustomerButton` | `Button`        | The button to assign a customer to the dealer.   |
| `SelectedDealer`       | `Dealer`        | The currently selected dealer.                   |

## Public Methods

| Method                   | Return Type | Description                                      |
| ------------------------ | ----------- | ------------------------------------------------ |
| `SetOpen(bool open)`     | `void`      | Opens or closes the app.                         |
| `SetDisplayedDealer(Dealer dealer)` | `void` | Sets the displayed dealer.                       |
| `AssignCustomer()`       | `void`      | Opens the customer selector.                     |
