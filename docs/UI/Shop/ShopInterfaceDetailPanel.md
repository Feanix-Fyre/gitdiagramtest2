# ShopInterfaceDetailPanel

The `ShopInterfaceDetailPanel` class is responsible for displaying the details of a shop listing. It shows the item's description and, if applicable, the rank required to unlock it.

## Public Properties

| Property         | Type              | Description                                      |
| ---------------- | ----------------- | ------------------------------------------------ |
| `Panel`          | `RectTransform`   | The `RectTransform` of the detail panel.         |
| `LayoutGroup`    | `VerticalLayoutGroup` | The `VerticalLayoutGroup` for the detail panel.  |
| `DescriptionLabel` | `TextMeshProUGUI` | The label for the item's description.            |
| `UnlockLabel`    | `TextMeshProUGUI` | The label for the unlock requirements.           |

## Public Methods

| Method              | Return Type | Description                                      |
| ------------------- | ----------- | ------------------------------------------------ |
| `Open(ListingUI _listing)` | `void`      | Opens the detail panel for a listing.            |
| `Close()`           | `void`      | Closes the detail panel.                         |
