# MoneyManager

The `MoneyManager` class is a network singleton that manages money in the game. It implements the `IBaseSaveable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ledger` | `List<Transaction>` | A list of all transactions. |
| `onlineBalance` | `float` | The player's online balance. |
| `lifetimeEarnings` | `float` | The player's lifetime earnings. |
| `CashSound` | `AudioSourceController` | The sound to play when cash is gained or lost. |
| `LaunderingNotificationIcon` | `Sprite` | The icon for the laundering notification. |
| `onNetworthCalculation` | `Action<FloatContainer>` | An event that is invoked when the net worth is calculated. |
| `LifetimeEarnings` | `float` | The player's lifetime earnings. |
| `LastCalculatedNetworth` | `float` | The last calculated net worth. |
| `cashBalance` | `float` | The player's cash balance. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the money data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the money data has changed and needs to be saved. |

## Methods

### `InitializeSaveable()`

Initializes the saveable object.

### `GetCashInstance(float amount)`

Gets a cash instance with a given amount.

**Parameters:**

* `amount`: The amount of cash.

**Returns:** `CashInstance`

### `CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)`

Creates an online transaction.

**Parameters:**

* `_transaction_Name`: The name of the transaction.
* `_unit_Amount`: The amount of a single unit.
* `_quantity`: The quantity of units.
* `_transaction_Note`: A note for the transaction.

### `ChangeLifetimeEarnings(float change)`

Changes the player's lifetime earnings.

**Parameters:**

* `change`: The amount to change the lifetime earnings by.

### `ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)`

Changes the player's cash balance.

**Parameters:**

* `change`: The amount to change the cash balance by.
* `visualizeChange`: If `true`, the change will be visualized.
* `playCashSound`: If `true`, a sound will be played.

### `FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)`

Formats an amount of money as a string.

**Parameters:**

* `amount`: The amount to format.
* `showDecimals`: If `true`, decimals will be shown.
* `includeColor`: If `true`, the string will be colored.

**Returns:** `string`

### `GetSaveString()`

Gets the save string for the money data.

**Returns:** `string`

### `Load(MoneyData data)`

Loads the money data.

**Parameters:**

* `data`: The data to load.

### `CheckNetworthAchievements()`

Checks the net worth achievements.

### `GetNetWorth()`

Gets the player's net worth.

**Returns:** `float`
