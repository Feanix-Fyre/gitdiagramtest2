# ClothingShopInterface

The `ClothingShopInterface` class inherits from `ShopInterface` and is used for clothing shops. It has a reference to a `ShopColorPicker`, which is used to allow the player to pick a color for a piece of clothing.

## Public Properties

| Property      | Type            | Description                                      |
| ------------- | --------------- | ------------------------------------------------ |
| `ColorPicker` | `ShopColorPicker` | The `ShopColorPicker` for this shop.             |

## Public Methods

| Method                  | Return Type | Description                                      |
| ----------------------- | ----------- | ------------------------------------------------ |
| `ListingClicked(ListingUI listingUI)` | `void`      | Called when a listing is clicked.                |
| `HandoverItems()`       | `bool`      | Handovers the items in the cart to the player.   |

## Protected Methods

| Method      | Return Type | Description             |
| ----------- | ----------- | ----------------------- |
| `Start()`   | `void`      | Initializes the component. |
| `Exit(ExitAction action)` | `void` | Called when the player exits the shop.           |
