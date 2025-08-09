# ShopManager

The `ShopManager` class is a `NetworkSingleton` that manages all the shops in the game. It handles saving and loading of shop data, and it also synchronizes the stock of items in the shops over the network.

## Public Properties

| Property                | Type           | Description                                      |
| ----------------------- | -------------- | ------------------------------------------------ |
| `SaveFileName`          | `string`       | The name of the save file for the shops.         |
| `Loader`                | `Loader`       | The loader to use for loading shop data.         |
| `ShouldSaveUnderFolder` | `bool`         | A boolean that indicates whether the save file should be saved under a folder. |
| `LocalExtraFiles`       | `List<string>` | A list of extra files to save.                   |
| `LocalExtraFolders`     | `List<string>` | A list of extra folders to save.                 |
| `HasChanged`            | `bool`         | A boolean that indicates whether the shop data has changed. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `InitializeSaveable()`                      | `void`      | Initializes the saveable.                        |
| `GetSaveString()`                           | `string`    | Gets the save string for all the shops.          |
| `SendStock(string shopCode, string itemID, int stock)` | `void` | Sends the stock of an item to the server.        |
| `SetStock(NetworkConnection conn, string shopCode, string itemID, int stock)` | `void` | Sets the stock of an item in a shop.             |
