# StorageTile

The `StorageTile` class represents a single tile in a storage grid. It is responsible for keeping track of its position in the grid and the item that is currently occupying it.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `x` | `int` | The x-coordinate of the tile in the grid. |
| `y` | `int` | The y-coordinate of the tile in the grid. |
| `ownerGrid` | `StorageGrid` | The storage grid that this tile belongs to. |
| `onOccupantChanged` | `Action` | An action that is invoked when the occupant of the tile changes. |
| `occupant` | `StoredItem` | The item that is currently occupying the tile. |

## Methods

### `InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)`

Initializes the storage tile.

**Parameters:**

* `_x`: The x-coordinate of the tile.
* `_y`: The y-coordinate of the tile.
* `_available_Offset`: The available offset of the tile.
* `_ownerGrid`: The storage grid that this tile belongs to.

### `SetOccupant(StoredItem occ)`

Sets the occupant of the tile.

**Parameters:**

* `occ`: The item to set as the occupant.
