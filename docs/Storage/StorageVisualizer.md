# StorageVisualizer

The `StorageVisualizer` class is responsible for visualizing the contents of a storage container. It displays the items in the container in a grid.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `StorageGrids` | `StorageGrid[]` | An array of storage grids to visualize. |
| `ItemContainer` | `Transform` | The transform that contains the item visuals. |
| `FullRefreshOnItemRemoved` | `bool` | If `true`, the visuals will be fully refreshed when an item is removed. |
| `BlockRefreshes` | `bool` | If `true`, refreshes will be blocked. |

## Methods

### `AddSlot(ItemSlot slot, bool update = false)`

Adds an item slot to the visualizer.

**Parameters:**

* `slot`: The item slot to add.
* `update`: If `true`, the visuals will be updated after adding the slot.

### `GetVisualRepresentation()`

Gets a visual representation of the contents of the storage container.

**Returns:** `Dictionary<StorableItemInstance, int>`

### `RefreshVisuals()`

Refreshes the visuals of the storage container.

### `GetContentsDictionary()`

Gets a dictionary of the contents of the storage container.

**Returns:** `Dictionary<StorableItemInstance, int>`
