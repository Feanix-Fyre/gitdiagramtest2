# SurfaceItem

The `SurfaceItem` class represents an item that can be placed on a surface. It inherits from the `BuildableItem` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ValidSurfaceTypes` | `List<Surface.ESurfaceType>` | A list of valid surface types that the item can be placed on. |
| `AllowRotation` | `bool` | If `true`, the item can be rotated. |
| `ParentSurface` | `Surface` | The surface that the item is placed on. |
| `RotationIncrement` | `float` | The increment at which the item can be rotated. |

## Methods

### `SendSurfaceItemData(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)`

Sends the surface item data to the server.

**Parameters:**

* `instance`: The item instance.
* `GUID`: The GUID of the item.
* `parentSurfaceGUID`: The GUID of the parent surface.
* `relativePosition`: The relative position of the item.
* `relativeRotation`: The relative rotation of the item.

### `InitializeSurfaceItem(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)`

Initializes the surface item.

**Parameters:**

* `conn`: The network connection.
* `instance`: The item instance.
* `GUID`: The GUID of the item.
* `parentSurfaceGUID`: The GUID of the parent surface.
* `relativePosition`: The relative position of the item.
* `relativeRotation`: The relative rotation of the item.

### `InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)`

Initializes the surface item.

**Parameters:**

* `instance`: The item instance.
* `GUID`: The GUID of the item.
* `parentSurfaceGUID`: The GUID of the parent surface.
* `relativePosition`: The relative position of the item.
* `relativeRotation`: The relative rotation of the item.

### `GetSaveString()`

Gets the save string for the surface item.

**Returns:** `string`
