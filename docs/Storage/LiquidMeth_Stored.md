# LiquidMeth_Stored

The `LiquidMeth_Stored` class represents a stored item of liquid meth. It inherits from the `StoredItem` class and adds the ability to display the visuals for the liquid meth.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Visuals` | `LiquidMethVisuals` | The visuals for the liquid meth. |

## Methods

### `InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)`

Initializes the stored item. This method is called when the item is first placed in a storage container.

**Parameters:**

* `_item`: The item instance to store.
* `grid`: The storage grid where the item is being placed.
* `_originCoordinate`: The origin coordinate of the item in the grid.
* `_rotation`: The rotation of the item.
