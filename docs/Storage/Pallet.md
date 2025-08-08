# Pallet

The `Pallet` class represents a pallet that can be used to store and transport items. It is a `NetworkBehaviour` and implements the `IStorageEntity` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `palletsOwnedByLocalPlayer` | `List<Pallet>` | A list of all pallets that are owned by the local player. |
| `sizeX` | `int` | The width of the pallet in grid units. |
| `sizeY` | `int` | The height of the pallet in grid units. |
| `_storedItemContainer` | `Transform` | The transform that contains the stored items. |
| `rb` | `Rigidbody` | The rigidbody of the pallet. |
| `storageGrid` | `StorageGrid` | The storage grid of the pallet. |
| `networkTransform` | `NetworkTransform` | The network transform of the pallet. |
| `currentSlotGUID` | `Guid` | The GUID of the pallet slot that the pallet is currently in. |
| `isEmpty` | `bool` | Returns `true` if the pallet is empty. |
| `carriedByForklift` | `bool` | Returns `true` if the pallet is being carried by a forklift. |
| `storedItemContainer` | `Transform` | The transform that contains the stored items. |
| `reservedItems` | `Dictionary<StoredItem, Employee>` | A dictionary of items that are reserved by employees. |

## Methods

### `DestroyPallet()`

Destroys the pallet.

### `BindToSlot_Server(Guid slotGuid)`

Binds the pallet to a pallet slot on the server.

**Parameters:**

* `slotGuid`: The GUID of the pallet slot to bind to.

### `ExitSlot_Server()`

Exits the current pallet slot on the server.

### `TriggerStay(Collider other)`

Called when a collider stays within the trigger.

**Parameters:**

* `other`: The collider that is staying within the trigger.

### `GetStoredItems()`

Returns a list of all stored items on the pallet.

**Returns:** `List<StoredItem>`

### `GetStorageGrids()`

Returns a list of all storage grids on the pallet.

**Returns:** `List<StorageGrid>`

### `CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)`

Creates a stored item on the pallet.

**Parameters:**

* `conn`: The network connection to create the item on.
* `item`: The item to create.
* `gridIndex`: The index of the grid to create the item in.
* `originCoord`: The origin coordinate of the item.
* `rotation`: The rotation of the item.
* `jobID`: The ID of the job that created the item.
* `network`: If `true`, the item will be created on the network.

### `DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)`

Destroys a stored item on the pallet.

**Parameters:**

* `gridIndex`: The index of the grid to destroy the item from.
* `coord`: The coordinate of the item to destroy.
* `jobID`: The ID of the job that destroyed the item.
* `network`: If `true`, the item will be destroyed on the network.
