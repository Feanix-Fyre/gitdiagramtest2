# ListingUI

The `ListingUI` class is the UI for a single listing in a shop. It displays the item's icon, name, price, and stock. It also has buttons for buying the item and for opening a dropdown menu.

## Public Properties

| Property                | Type              | Description                                      |
| ----------------------- | ----------------- | ------------------------------------------------ |
| `PriceLabelColor_Normal`| `Color32`           | The color to use for the price label when the item is in stock. |
| `PriceLabelColor_NoStock`| `Color32`          | The color to use for the price label when the item is out of stock. |
| `StockLabelDefault`     | `Color32`           | The default color for the stock label.           |
| `StockLabelNone`        | `Color32`           | The color to use for the stock label when the item is out of stock. |
| `Icon`                  | `Image`           | The icon for the item.                           |
| `NameLabel`             | `TextMeshProUGUI` | The label for the item's name.                 |
| `PriceLabel`            | `TextMeshProUGUI` | The label for the item's price.                |
| `StockLabel`            | `TextMeshProUGUI` | The label for the item's stock.                |
| `LockedContainer`       | `GameObject`      | The container for the locked icon.               |
| `BuyButton`             | `Button`          | The button to buy the item.                      |
| `DropdownButton`        | `Button`          | The button to open the dropdown menu.            |
| `Trigger`               | `EventTrigger`    | The event trigger for the listing.               |
| `DetailPanelAnchor`     | `RectTransform`   | The anchor for the detail panel.                 |
| `DropdownAnchor`        | `RectTransform`   | The anchor for the dropdown menu.                |
| `TopDropdownAnchor`     | `RectTransform`   | The anchor for the top of the dropdown menu.     |
| `hoverStart`            | `Action`          | An event that is invoked when the mouse hovers over the listing. |
| `hoverEnd`              | `Action`          | An event that is invoked when the mouse stops hovering over the listing. |
| `onClicked`             | `Action`          | An event that is invoked when the listing is clicked. |
| `onDropdownClicked`     | `Action`          | An event that is invoked when the dropdown button is clicked. |
| `Listing`               | `ShopListing`     | The `ShopListing` that this UI represents.     |

## Public Methods

| Method                   | Return Type | Description                                      |
| ------------------------ | ----------- | ------------------------------------------------ |
| `Initialize(ShopListing listing)` | `void`      | Initializes the UI with a listing.               |
| `GetIconCopy(RectTransform parent)` | `RectTransform` | Gets a copy of the icon.                         |
| `Update()`               | `void`      | Updates the UI.                                  |
| `CanAddToCart()`           | `bool`      | Checks if the item can be added to the cart.     |
| `UpdateLockStatus()`     | `void`      | Updates the lock status of the listing.          |
