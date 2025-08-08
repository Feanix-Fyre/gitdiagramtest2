# StorageGrid

The `StorageGrid` class represents a grid of storage tiles that can be used to store items. It provides methods for managing the tiles, checking if an item can fit in the grid, and finding a valid position for an item.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `gridSize` | `float` | The size of each tile in the grid. |
| `storageTiles` | `List<StorageTile>` | A list of all storage tiles in the grid. |
| `freeTiles` | `List<StorageTile>` | A list of all free storage tiles in the grid. |
| `coordinateStorageTilePairs` | `List<CoordinateStorageTilePair>` | A list of coordinate and storage tile pairs that define the grid. |

## Methods

### `RegisterTile(StorageTile tile)`

Registers a storage tile with the grid.

**Parameters:**

* `tile`: The tile to register.

### `DeregisterTile(StorageTile tile)`

Deregisters a storage tile from the grid.

**Parameters:**

* `tile`: The tile to deregister.

### `IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)`

Checks if the position of an item is valid in the grid.

**Parameters:**

* `primaryTile`: The primary tile of the item.
* `primaryFootprintTile`: The primary footprint tile of the item.
* `item`: The item to check.

**Returns:** `bool`

### `GetMatchedCoordinate(FootprintTile tileToMatch)`

Gets the coordinate in the grid that matches the given footprint tile.

**Parameters:**

* `tileToMatch`: The footprint tile to match.

**Returns:** `Coordinate`

### `IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)`

Checks if a position in the grid is valid.

**Parameters:**

* `gridCoord`: The coordinate to check.
* `tile`: The footprint tile to check.

**Returns:** `bool`

### `GetTile(Coordinate coord)`

Gets the storage tile at the given coordinate.

**Parameters:**

* `coord`: The coordinate to get the tile at.

**Returns:** `StorageTile`

### `GetUserEndCapacity()`

Gets the user-end capacity of the grid.

**Returns:** `int`

### `GetActualY()`

Gets the actual height of the grid.

**Returns:** `int`

### `GetActualX()`

Gets the actual width of the grid.

**Returns:** `int`

### `GetTotalFootprintSize()`

Gets the total size of the grid's footprint.

**Returns:** `int`

### `TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)`

Tries to fit an item of the given size into the grid.

**Parameters:**

* `sizeX`: The width of the item.
* `sizeY`: The height of the item.
* `lockedCoordinates`: A list of coordinates that are locked and cannot be used.
* `originCoordinate`: The origin coordinate of the item in the grid.
* `rotation`: The rotation of the item.

**Returns:** `bool`
