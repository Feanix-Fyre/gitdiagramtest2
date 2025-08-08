# StorableItemInstance

The `StorableItemInstance` class represents an instance of a storable item. It inherits from the `ItemInstance` class and adds a reference to the `StoredItem` prefab that is used to represent the item in a storage container.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `StoredItem` | `StoredItem` | The `StoredItem` prefab that is used to represent the item in a storage container. |

## Constructors

### `StorableItemInstance()`

Initializes a new instance of the `StorableItemInstance` class.

### `StorableItemInstance(ItemDefinition definition, int quantity)`

Initializes a new instance of the `StorableItemInstance` class with the given definition and quantity.

**Parameters:**

* `definition`: The definition of the item.
* `quantity`: The quantity of the item.

## Methods

### `GetCopy(int overrideQuantity = -1)`

Gets a copy of the item instance.

**Parameters:**

* `overrideQuantity`: The quantity to override the copy with.

**Returns:** `ItemInstance`

### `GetMonetaryValue()`

Gets the monetary value of the item.

**Returns:** `float`
