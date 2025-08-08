# ProceduralGridItem

The `ProceduralGridItem` class represents a grid item that is procedurally generated. It inherits from the `BuildableItem` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `CoordinateFootprintTilePairs` | `List<CoordinateFootprintTilePair>` | A list of coordinate and footprint tile pairs that define the item's footprint. |
| `ProceduralTileType` | `ProceduralTile.EProceduralTileType` | The type of procedural tile that the item is. |
| `Rotation` | `int` | The rotation of the item on the grid. |
| `footprintTileMatches` | `List<CoordinateProceduralTilePair>` | A list of footprint tile matches. |
| `FootprintXSize` | `int` | The width of the item's footprint. |
| `FootprintYSize` | `int` | The height of the item's footprint. |

## Methods

### `SendProceduralGridItemData(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)`

Sends the procedural grid item data to the server.

**Parameters:**

* `instance`: The item instance.
* `_rotation`: The rotation of the item.
* `_footprintTileMatches`: A list of footprint tile matches.
* `GUID`: The GUID of the item.

### `InitializeProceduralGridItem(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)`

Initializes the procedural grid item.

**Parameters:**

* `conn`: The network connection.
* `instance`: The item instance.
* `_rotation`: The rotation of the item.
* `_footprintTileMatches`: A list of footprint tile matches.
* `GUID`: The GUID of the item.

### `InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)`

Initializes the procedural grid item.

**Parameters:**

* `instance`: The item instance.
* `_rotation`: The rotation of the item.
* `_footprintTileMatches`: A list of footprint tile matches.
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

### `GetSaveString()`

Gets the save string for the procedural grid item.

**Returns:** `string`
