# DeadDrop

The `DeadDrop` class represents a dead drop location where items can be left for other players. It implements the `IGUIDRegisterable` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `DeadDrops` | `List<DeadDrop>` | A list of all dead drops. |
| `DeadDropName` | `string` | The name of the dead drop. |
| `DeadDropDescription` | `string` | A description of the dead drop. |
| `Storage` | `StorageEntity` | The storage entity for the dead drop. |
| `PoI` | `POI` | The point of interest for the dead drop. |
| `Light` | `OptimizedLight` | The light for the dead drop. |
| `ItemCountVariable` | `string` | The name of the variable that stores the number of items in the dead drop. |
| `GUID` | `Guid` | The GUID of the dead drop. |

## Methods

### `RegenerateGUID()`

Regenerates the GUID of the dead drop.

### `SetGUID(Guid guid)`

Sets the GUID of the dead drop.

**Parameters:**

* `guid`: The GUID to set.

### `GetRandomEmptyDrop(Vector3 origin)`

Gets a random empty dead drop.

**Parameters:**

* `origin`: The origin to get the dead drop from.

**Returns:** `DeadDrop`
