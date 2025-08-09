# MetadataManager

The `MetadataManager` class is a singleton that manages metadata for the game. It implements the `IBaseSaveable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `CreationDate` | `DateTime` | The creation date of the save file. |
| `CreationVersion` | `string` | The creation version of the save file. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the metadata. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the metadata has changed and needs to be saved. |

## Methods

### `InitializeSaveable()`

Initializes the saveable object.

### `GetSaveString()`

Gets the save string for the metadata.

**Returns:** `string`

### `Load(MetaData data)`

Loads the metadata.

**Parameters:**

* `data`: The metadata to load.
