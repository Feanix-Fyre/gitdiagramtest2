# WorldStorageEntity

The `WorldStorageEntity` class represents a storage entity that exists in the world and can be saved and loaded. It inherits from the `StorageEntity` class and implements the `IGUIDRegisterable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `All` | `List<WorldStorageEntity>` | A list of all world storage entities. |
| `GUID` | `Guid` | The GUID of the world storage entity. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the storage data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the storage data has changed and needs to be saved. |

## Methods

### `RegenerateGUID()`

Regenerates the GUID of the world storage entity.

### `InitializeSaveable()`

Initializes the saveable object.

### `SetGUID(Guid guid)`

Sets the GUID of the world storage entity.

**Parameters:**

* `guid`: The GUID to set.

### `ShouldSave()`

Returns `true` if the world storage entity should be saved.

**Returns:** `bool`

### `GetSaveData()`

Gets the save data for the world storage entity.

**Returns:** `WorldStorageEntityData`

### `GetSaveString()`

Gets the save string for the world storage data.

**Returns:** `string`

### `Load(WorldStorageEntityData data)`

Loads the world storage entity from the given save data.

**Parameters:**

* `data`: The save data to load from.
