# StorageEntity

The `StorageEntity` class represents a generic storage container for items in the game. It is a `NetworkBehaviour`, meaning it is synchronized across the network. It also implements the `IItemSlotOwner` interface, which provides a contract for objects that can own item slots.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `StorageEntityName` | `string` | The name of the storage entity. |
| `StorageEntitySubtitle` | `string` | A subtitle for the storage entity. |
| `SlotCount` | `int` | The number of item slots in this storage entity. |
| `EmptyOnSleep` | `bool` | If true, the storage entity will be emptied when the player sleeps. |
| `DisplayRowCount` | `int` | The number of rows to enforce when displaying the contents in the `StorageMenu`. |
| `AccessSettings` | `EAccessSettings` | The access settings for this storage entity. |
| `MaxAccessDistance` | `float` | The maximum distance from which the player can access this storage entity. |
| `IsOpened` | `bool` | Returns `true` if the storage entity is currently being accessed by a player. |
| `CurrentAccessor` | `Player` | The player who is currently accessing this storage entity. |
| `ItemCount` | `int` | The total number of items in this storage entity. |
| `ItemSlots` | `List<ItemSlot>` | The list of item slots in this storage entity. |

## Events

| Name | Description |
| --- | --- |
| `onOpened` | Invoked when this storage entity is accessed in the `StorageMenu`. |
| `onClosed` | Invoked when the `StorageMenu` is closed. |
| `onContentsChanged` | Invoked when the contents change in any way (item added, removed, or quantity changed). |

## Methods

### `GetContentsDictionary()`

Returns a dictionary of all storable items in the storage entity and their quantities.

**Returns:** `Dictionary<StorableItemInstance, int>`

### `CanItemFit(ItemInstance item, int quantity = 1)`

Checks if the given item can fit in the storage entity.

**Parameters:**

* `item`: The item to check.
* `quantity`: The quantity of the item to check.

**Returns:** `bool`

### `HowManyCanFit(ItemInstance item)`

Calculates how many of the given item can fit in the storage entity.

**Parameters:**

* `item`: The item to check.

**Returns:** `int`

### `InsertItem(ItemInstance item, bool network = true)`

Inserts an item into the storage entity.

**Parameters:**

* `item`: The item to insert.
* `network`: If `true`, the insertion will be synchronized across the network.

### `GetAllItems()`

Returns a list of all items in the storage entity.

**Returns:** `List<ItemInstance>`

### `LoadFromItemSet(ItemInstance[] items)`

Loads items into the storage entity from an array of `ItemInstance`.

**Parameters:**

* `items`: The array of items to load.

### `ClearContents()`

Clears all items from the storage entity.

### `Open()`

Opens the storage entity in the `StorageMenu`.

### `Close()`

Closes the storage entity in the `StorageMenu`.

### `CanBeOpened()`

Checks if the storage entity can be opened.

**Returns:** `bool`
