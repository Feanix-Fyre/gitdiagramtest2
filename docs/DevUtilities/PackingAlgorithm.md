# PackingAlgorithm

The `PackingAlgorithm` class is a singleton that provides a packing algorithm for packing items into a grid.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `rectsToPack` | `List<Rectangle>` | A list of rectangles to pack. |

## Methods

### `PackItems(List<ItemInstance> datas, int gridX, int gridY)`

Packs a list of items into a grid.

**Parameters:**

* `datas`: The list of items to pack.
* `gridX`: The width of the grid.
* `gridY`: The height of the grid.

**Returns:** `List<StoredItemData>`

### `AttemptPack(List<StoredItemData> rects, int gridX, int gridY)`

Attempts to pack a list of rectangles into a grid.

**Parameters:**

* `rects`: The list of rectangles to pack.
* `gridX`: The width of the grid.
* `gridY`: The height of the grid.

**Returns:** `List<StoredItemData>`
