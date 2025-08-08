# BuildableItem

The `BuildableItem` class represents an item that can be built in the world. It inherits from the `NetworkBehaviour` class and implements the `IGUIDRegisterable` and `ISaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `isGhost` | `bool` | If `true`, the item is a ghost item. |
| `HoldDistance` | `float` | The distance at which the item can be held. |
| `BuildPoint` | `Transform` | The point from which the item is built. |
| `MidAirCenterPoint` | `Transform` | The center point of the item when it is in mid-air. |
| `BoundingCollider` | `BoxCollider` | The bounding collider for the item. |
| `onInitialized` | `UnityEvent` | An event that is invoked when the item is initialized. |
| `onDestroyed` | `UnityEvent` | An event that is invoked when the item is destroyed. |
| `onDestroyedWithParameter` | `Action<BuildableItem>` | An event that is invoked when the item is destroyed. |
| `ItemInstance` | `ItemInstance` | The item instance for the item. |
| `ParentProperty` | `Property` | The parent property of the item. |
| `IsDestroyed` | `bool` | Returns `true` if the item has been destroyed. |
| `Initialized` | `bool` | Returns `true` if the item has been initialized. |
| `GUID` | `Guid` | The GUID of the item. |
| `IsCulled` | `bool` | Returns `true` if the item is culled. |
| `BuildHandler` | `GameObject` | The build handler for the item. |
| `LocallyBuilt` | `bool` | Returns `true` if the item was built locally. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the buildable item data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the buildable item data has changed and needs to be saved. |

## Methods

### `AddChildMeshes()`

Adds all child meshes to the list of meshes to cull.

### `SetLocallyBuilt()`

Sets the item as locally built.

### `InitializeSaveable()`

Initializes the saveable object.

### `SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)`

Sends the buildable item data to the server.

**Parameters:**

* `instance`: The item instance.
* `GUID`: The GUID of the item.
* `parentPropertyCode`: The property code of the parent property.

### `ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)`

Receives the buildable item data from the server.

**Parameters:**

* `conn`: The network connection.
* `instance`: The item instance.
* `GUID`: The GUID of the item.
* `parentPropertyCode`: The property code of the parent property.

### `InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)`

Initializes the buildable item.

**Parameters:**

* `instance`: The item instance.
* `GUID`: The GUID of the item.
* `parentPropertyCode`: The property code of the parent property.

### `CanBePickedUp(out string reason)`

Returns `true` if the item can be picked up.

**Parameters:**

* `reason`: Returns the reason why the item cannot be picked up.

**Returns:** `bool`

### `CanBeDestroyed(out string reason)`

Returns `true` if the item can be destroyed.

**Parameters:**

* `reason`: Returns the reason why the item cannot be destroyed.

**Returns:** `bool`

### `PickupItem()`

Picks up the item.

### `DestroyItem(bool callOnServer = true)`

Destroys the item.

**Parameters:**

* `callOnServer`: If `true`, the item will be destroyed on the server.

### `SetGUID(Guid guid)`

Sets the GUID of the item.

**Parameters:**

* `guid`: The GUID to set.

### `GetColorFromOutlineColorEnum(EOutlineColor col)`

Gets a color from an outline color enum.

**Parameters:**

* `col`: The outline color enum to get the color from.

**Returns:** `Color32`

### `ShowOutline(Color color)`

Shows the outline for the item.

**Parameters:**

* `color`: The color of the outline.

### `ShowOutline(EOutlineColor color)`

Shows the outline for the item.

**Parameters:**

* `color`: The color of the outline.

### `HideOutline()`

Hides the outline for the item.

### `GetFurthestPointFromBoundingCollider(Vector3 pos)`

Gets the furthest point on the bounding collider from a given position.

**Parameters:**

* `pos`: The position to get the furthest point from.

**Returns:** `Vector3`

### `GetPenetration(out float x, out float z, out float y)`

Gets the penetration of the item.

**Parameters:**

* `x`: Returns the penetration on the x-axis.
* `z`: Returns the penetration on the z-axis.
* `y`: Returns the penetration on the y-axis.

**Returns:** `bool`

### `SetCulled(bool culled)`

Sets whether the item is culled.

**Parameters:**

* `culled`: If `true`, the item is culled.

### `GetSaveString()`

Gets the save string for the buildable item.

**Returns:** `string`

### `WriteData(string parentFolderPath)`

Writes the buildable item data to a file.

**Parameters:**

* `parentFolderPath`: The path to the parent folder.

**Returns:** `List<string>`
