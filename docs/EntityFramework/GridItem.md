# GridItem

The `GridItem` class represents an item that can be placed on a grid. It inherits from the `BuildableItem` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `CoordinateFootprintTilePairs` | `List<CoordinateFootprintTilePair>` | A list of coordinate and footprint tile pairs that define the item's footprint. |
| `GridType` | `EGridType` | The type of grid that the item can be placed on. |
| `OwnerGridGUID` | `Guid` | The GUID of the grid that the item is on. |
| `OriginCoordinate` | `Vector2` | The origin coordinate of the item on the grid. |
| `Rotation` | `int` | The rotation of the item on the grid. |
| `CoordinatePairs` | `List<CoordinatePair>` | A list of coordinate pairs that define the item's position on the grid. |
| `OriginFootprint` | `FootprintTile` | The origin footprint tile of the item. |
| `FootprintX` | `int` | The width of the item's footprint. |
| `FootprintY` | `int` | The height of the item's footprint. |
| `OwnerGrid` | `Grid` | The grid that the item is on. |

## Methods

### `SendGridItemData(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)`

Sends the grid item data to the server.

**Parameters:**

* `instance`: The item instance.
* `gridGUID`: The GUID of the grid.
* `originCoordinate`: The origin coordinate of the item.
* `rotation`: The rotation of the item.
* `GUID`: The GUID of the item.

### `InitializeGridItem(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)`

Initializes the grid item.

**Parameters:**

* `conn`: The network connection.
* `instance`: The item instance.
* `gridGUID`: The GUID of the grid.
* `originCoordinate`: The origin coordinate of the item.
* `rotation`: The rotation of the item.
* `GUID`: The GUID of the item.

### `InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)`

Initializes the grid item.

**Parameters:**

* `instance`: The item instance.
* `grid`: The grid that the item is on.
* `originCoordinate`: The origin coordinate of the item.
* `rotation`: The rotation of the item.
* `GUID`: The GUID of the item.

### `DestroyItem(bool callOnServer = true)`

Destroys the item.

**Parameters:**

* `callOnServer`: If `true`, the item will be destroyed on the server.

### `CalculateFootprintTileIntersections()`

Calculates the intersections of the item's footprint tiles.

### `SetFootprintTileVisiblity(bool visible)`

Sets the visibility of the item's footprint tiles.

**Parameters:**

* `visible`: If `true`, the footprint tiles will be visible.

### `GetFootprintTile(Coordinate coord)`

Gets the footprint tile at the given coordinate.

**Parameters:**

* `coord`: The coordinate to get the tile at.

**Returns:** `FootprintTile`

### `GetParentTileAtFootprintCoordinate(Coordinate footprintCoord)`

Gets the parent tile at the given footprint coordinate.

**Parameters:**

* `footprintCoord`: The footprint coordinate to get the parent tile at.

**Returns:** `Tile`

### `CanShareTileWith(List<GridItem> obstacles)`

Returns `true` if the item can share a tile with the given obstacles.

**Parameters:**

* `obstacles`: The list of obstacles to check.

**Returns:** `bool`

### `GetSaveString()`

Gets the save string for the grid item.

**Returns:** `string`
