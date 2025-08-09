# StationItem

The `StationItem` class is a component that represents an item that can be used in a station.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Modules` | `List<ItemModule>` | A list of all modules for the item. |
| `TrashPrefab` | `TrashItem` | The prefab for the trash item that is created when the item is destroyed. |
| `ActiveModules` | `List<ItemModule>` | A list of all active modules for the item. |

## Methods

### `Initialize(StorableItemDefinition itemDefinition)`

Initializes the station item.

**Parameters:**

* `itemDefinition`: The item definition to initialize the item with.

### `ActivateModule<T>()`

Activates a module.

### `Destroy()`

Destroys the station item.

### `HasModule<T>()`

Returns `true` if the item has a module of the given type.

**Returns:** `bool`

### `GetModule<T>()`

Gets a module of the given type.

**Returns:** `T`
