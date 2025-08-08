# StorageManager

The `StorageManager` class is a singleton that manages all storage entities in the world. It is responsible for creating pallets and saving and loading storage data. It inherits from `NetworkSingleton<StorageManager>` and implements the `IBaseSaveable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `PalletPrefab` | `GameObject` | The prefab for the pallet. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the storage data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the storage data has changed and needs to be saved. |

## Methods

### `CreatePallet(Vector3 position, Quaternion rotation, string initialSlotGuid = "")`

Creates a new pallet at the given position and rotation.

**Parameters:**

* `position`: The position to create the pallet at.
* `rotation`: The rotation of the pallet.
* `initialSlotGuid`: The GUID of the initial slot to bind the pallet to.

**Returns:** `Pallet`

### `InitializeSaveable()`

Initializes the saveable object.

### `GetSaveString()`

Gets the save string for the storage data.

**Returns:** `string`
