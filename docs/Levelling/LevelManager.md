# LevelManager

The `LevelManager` class is a singleton that manages the player's level and rank. It is a `NetworkSingleton` and implements the `IBaseSaveable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onRankUp` | `Action<FullRank, FullRank>` | An event that is invoked when the player ranks up. |
| `Unlockables` | `Dictionary<FullRank, List<Unlockable>>` | A dictionary of all unlockables in the game. |
| `Rank` | `ERank` | The player's current rank. |
| `Tier` | `int` | The player's current tier. |
| `XP` | `int` | The player's current experience points. |
| `TotalXP` | `int` | The player's total experience points. |
| `XPToNextTier` | `float` | The amount of experience points required to reach the next tier. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the level data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the level data has changed and needs to be saved. |

## Methods

### `InitializeSaveable()`

Initializes the saveable object.

### `AddXP(int xp)`

Adds experience points to the player.

**Parameters:**

* `xp`: The amount of experience points to add.

### `SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)`

Sets the player's level data.

**Parameters:**

* `conn`: The network connection to set the data on.
* `rank`: The player's rank.
* `tier`: The player's tier.
* `xp`: The player's experience points.
* `totalXp`: The player's total experience points.

### `GetSaveString()`

Gets the save string for the level data.

**Returns:** `string`

### `GetFullRank()`

Gets the player's full rank.

**Returns:** `FullRank`

### `AddUnlockable(Unlockable unlockable)`

Adds an unlockable to the game.

**Parameters:**

* `unlockable`: The unlockable to add.

### `GetTotalXPForRank(FullRank fullrank)`

Gets the total experience points required to reach a certain rank.

**Parameters:**

* `fullrank`: The rank to get the total experience points for.

**Returns:** `int`

### `GetFullRank(int totalXp)`

Gets the full rank for a certain amount of total experience points.

**Parameters:**

* `totalXp`: The total experience points to get the rank for.

**Returns:** `FullRank`

### `GetXPForTier(ERank rank)`

Gets the amount of experience points required to reach the next tier for a certain rank.

**Parameters:**

* `rank`: The rank to get the experience points for.

**Returns:** `int`

### `GetOrderLimitMultiplier(FullRank rank)`

Gets the order limit multiplier for a certain rank.

**Parameters:**

* `rank`: The rank to get the order limit multiplier for.

**Returns:** `float`
