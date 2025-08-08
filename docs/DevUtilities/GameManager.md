# GameManager

The `GameManager` class is a network singleton that manages the game state. It implements the `IBaseSaveable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `IS_BETA` | `bool` | If `true`, the game is in beta mode. |
| `OrganisationName` | `string` | The name of the player's organisation. |
| `Settings` | `GameSettings` | The game settings. |
| `SpawnPoint` | `Transform` | The spawn point for the player. |
| `NoHomeRespawnPoint` | `Transform` | The respawn point for the player if they don't have a home. |
| `Temp` | `Transform` | A temporary transform. |
| `onSettingsLoaded` | `UnityEvent` | An event that is invoked when the settings are loaded. |
| `IS_TUTORIAL` | `bool` | Returns `true` if the game is in tutorial mode. |
| `Seed` | `int` | The seed for the random number generator. |
| `OrganisationLogo` | `Sprite` | The logo for the player's organisation. |
| `IsTutorial` | `bool` | Returns `true` if the game is in tutorial mode. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the game data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the game data has changed and needs to be saved. |

## Methods

### `SetGameData(NetworkConnection conn, GameData data)`

Sets the game data.

**Parameters:**

* `conn`: The network connection to set the game data on.
* `data`: The game data to set.

### `InitializeSaveable()`

Initializes the saveable object.

### `GetSaveString()`

Gets the save string for the game data.

**Returns:** `string`

### `Load(GameData data, string path)`

Loads the game data.

**Parameters:**

* `data`: The game data to load.
* `path`: The path to the save file.

### `EndTutorial(bool natural)`

Ends the tutorial.

**Parameters:**

* `natural`: If `true`, the tutorial was ended naturally.
