# StoredItem_GenericBox

The `StoredItem_GenericBox` class represents a generic box that can be stored in a storage container. It inherits from the `StoredItem` class and adds the ability to display an icon for the item.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `IconScale` | `float` | The scale of the icon. |

## Methods

### `InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)`

Initializes the stored item. This method is called when the item is first placed in a storage container.

**Parameters:**

* `_item`: The item instance to store.
* `grid`: The storage grid where the item is being placed.
* `_originCoordinate`: The origin coordinate of the item in the grid.
* `_rotation`: The rotation of the item.
