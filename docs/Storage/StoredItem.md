# StoredItem

The `StoredItem` class represents an item that is stored in a storage container. It is responsible for managing the item's position and rotation in the grid, as well as its interaction with the player.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `buildPoint` | `Transform` | The point from which the item is built. |
| `CoordinateFootprintTilePairs` | `List<CoordinateStorageFootprintTilePair>` | A list of coordinate and footprint tile pairs that define the item's footprint. |
| `xSize` | `int` | The width of the item in grid units. |
| `ySize` | `int` | The height of the item in grid units. |
| `item` | `StorableItemInstance` | The item instance that is being stored. |
| `Destroyed` | `bool` | Returns `true` if the item has been destroyed. |
| `OriginFootprint` | `FootprintTile` | The origin footprint tile of the item. |
| `FootprintX` | `int` | The width of the item's footprint. |
| `FootprintY` | `int` | The height of the item's footprint. |
| `parentStorageEntity` | `IStorageEntity` | The storage entity that this item is stored in. |
| `parentGrid` | `StorageGrid` | The storage grid that this item is stored in. |
| `CoordinatePairs` | `List<CoordinatePair>` | A list of coordinate pairs that define the item's position in the grid. |
| `Rotation` | `float` | The rotation of the item in the grid. |
| `totalArea` | `int` | The total area of the item's footprint. |
| `canBePickedUp` | `bool` | Returns `true` if the item can be picked up by the player. |
| `noPickupReason` | `string` | The reason why the item cannot be picked up. |

## Methods

### `InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)`

Initializes the stored item. This method is called when the item is first placed in a storage container.

**Parameters:**

* `_item`: The item instance to store.
* `grid`: The storage grid where the item is being placed.
* `_originCoordinate`: The origin coordinate of the item in the grid.
* `_rotation`: The rotation of the item.

### `Destroy_Internal()`

Destroys the item internally. This method is called when the item is removed from the storage container.

### `DestroyStoredItem()`

Destroys the stored item.

### `ClearFootprintOccupancy()`

Clears the occupancy of the item's footprint in the storage grid.

### `SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")`

Sets whether the item can be picked up by the player.

**Parameters:**

* `_canBePickedUp`: If `true`, the item can be picked up.
* `_noPickupReason`: The reason why the item cannot be picked up.

### `SetLayerRecursively(GameObject go, int layerNumber)`

Sets the layer of a game object and all of its children.

**Parameters:**

* `go`: The game object to set the layer of.
* `layerNumber`: The layer to set.

### `RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)`

Removes reserved items from a list of stored items.

**Parameters:**

* `itemList`: The list of stored items to filter.
* `allowedReservant`: The employee who is allowed to have reserved items.

**Returns:** `List<StoredItem>`

### `CreateGhostModel(ItemInstance _item, Transform parent)`

Creates a ghost model of the item.

**Parameters:**

* `_item`: The item to create a ghost model of.
* `parent`: The parent transform for the ghost model.

**Returns:** `GameObject`

### `SetFootprintTileVisiblity(bool visible)`

Sets the visibility of the item's footprint tiles.

**Parameters:**

* `visible`: If `true`, the footprint tiles will be visible.

### `CalculateFootprintTileIntersections()`

Calculates the intersections of the item's footprint tiles.

### `GetTile(Coordinate coord)`

Gets the footprint tile at the given coordinate.

**Parameters:**

* `coord`: The coordinate to get the tile at.

**Returns:** `FootprintTile`

### `Hovered()`

Called when the player hovers over the item.

### `Interacted()`

Called when the player interacts with the item.
