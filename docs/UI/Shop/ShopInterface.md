# ShopInterface

The `ShopInterface` class is a large and complex class that manages the UI for a shop. It handles everything from displaying the shop's inventory to managing the player's cart and processing transactions. It also has a lot of functionality for saving and loading shop data, as well as for synchronizing shop data over the network.

## Enums

### EPaymentType

This enum defines the different payment types that a shop can accept.

-   `Cash`: The shop only accepts cash.
-   `Online`: The shop only accepts online payments.
-   `PreferCash`: The shop prefers cash, but will accept online payments.
-   `PreferOnline`: The shop prefers online payments, but will accept cash.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `AllShops`              | `List<ShopInterface>`     | A static list of all the shops in the game.      |
| `MAX_ITEM_QUANTITY`     | `int`                     | The maximum quantity of an item that can be purchased at once. |
| `ShopName`              | `string`                  | The name of the shop.                            |
| `ShopCode`              | `string`                  | The code for the shop.                           |
| `PaymentType`           | `EPaymentType`            | The payment type that the shop accepts.          |
| `ShowCurrencyHint`      | `bool`                    | If true, a hint will be shown about the shop's currency. |
| `Listings`              | `List<ShopListing>`       | A list of all the listings in the shop.          |
| `Canvas`                | `Canvas`                  | The canvas for the UI.                           |
| `Container`             | `RectTransform`           | The container for the UI elements.               |
| `ListingContainer`      | `RectTransform`           | The container for the listing UI elements.       |
| `StoreNameLabel`        | `TextMeshProUGUI`         | The label for the store's name.                  |
| `Cart`                  | `Cart`                    | The `Cart` component for this shop.              |
| `DeliveryBays`          | `StorageEntity[]`         | An array of `StorageEntity`s for the delivery bays. |
| `LoadingBayDetector`    | `VehicleDetector`         | The `VehicleDetector` for the loading bay.       |
| `DetailPanel`           | `ShopInterfaceDetailPanel`| The detail panel for the shop.                   |
| `ListingScrollRect`     | `ScrollRect`              | The scroll rect for the listings.                |
| `AmountSelector`        | `ShopAmountSelector`      | The amount selector for the shop.                |
| `DeliveryVehicle`       | `DeliveryVehicle`         | The delivery vehicle for the shop.               |
| `AddItemSound`          | `AudioSourceController`   | The sound to play when an item is added to the cart. |
| `RemoveItemSound`       | `AudioSourceController`   | The sound to play when an item is removed from the cart. |
| `CheckoutSound`         | `AudioSourceController`   | The sound to play when the player checks out.    |
| `ListingUIPrefab`       | `ListingUI`               | The prefab for the listing UI.                   |
| `onOrderCompleted`      | `UnityEvent`              | An event that is invoked when an order is completed. |
| `IsOpen`                | `bool`                    | A boolean that indicates whether the UI is open. |
| `SaveFileName`          | `string`                  | The name of the save file for the shop.          |
| `Loader`                | `Loader`                  | The loader to use for loading shop data.         |
| `ShouldSaveUnderFolder` | `bool`                    | A boolean that indicates whether the save file should be saved under a folder. |
| `LocalExtraFiles`       | `List<string>`            | A list of extra files to save.                   |
| `LocalExtraFolders`     | `List<string>`            | A list of extra folders to save.                 |
| `HasChanged`            | `bool`                    | A boolean that indicates whether the shop data has changed. |

## Public Methods

| Method                                      | Return Type         | Description                                      |
| ------------------------------------------- | ------------------- | ------------------------------------------------ |
| `InitializeSaveable()`                      | `void`              | Initializes the saveable.                        |
| `Open()`                                    | `void`              | Opens the shop.                                  |
| `SetIsOpen(bool isOpen)`                    | `void`              | Sets whether the shop is open.                   |
| `SelectCategory(EShopCategory category)`    | `void`              | Selects a category in the shop.                  |
| `ListingClicked(ListingUI listingUI)`       | `void`              | Called when a listing is clicked.                |
| `CategorySelected(EShopCategory category)`  | `void`              | Called when a category is selected.              |
| `CanCartFitItem(ShopListing listing)`       | `bool`              | Checks if the cart can fit an item.              |
| `WillCartFit()`                             | `bool`              | Checks if the cart will fit.                     |
| `WillCartFit(List<ItemSlot> availableSlots)`| `bool`              | Checks if the cart will fit in the given slots.  |
| `HandoverItems()`                           | `bool`              | Handovers the items in the cart to the player.   |
| `GetAvailableSlots()`                       | `List<ItemSlot>`    | Gets the available slots for the player.         |
| `GetLoadingBayVehicle()`                    | `LandVehicle`       | Gets the vehicle in the loading bay.             |
| `PlaceItemInDeliveryBay(ItemInstance item)` | `void`              | Places an item in the delivery bay.              |
| `QuantitySelected(int amount)`              | `void`              | Called when a quantity is selected.              |
| `OpenAmountSelector(ListingUI listing)`     | `void`              | Opens the amount selector for a listing.         |
| `Load(ShopData data)`                       | `void`              | Loads the shop's data.                           |
| `ShouldSave()`                              | `bool`              | Checks if the shop should be saved.              |
| `GetListing(string itemID)`                 | `ShopListing`       | Gets a listing by its item ID.                   |
| `GetSaveData()`                             | `ShopData`          | Gets the shop's save data.                       |
| `GetSaveString()`                           | `string`            | Gets the save string for the shop.               |
