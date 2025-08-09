# PlayerSingleton<T>

The `PlayerSingleton<T>` class is an abstract class that provides a generic implementation of the singleton pattern for player objects.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `InstanceExists` | `bool` | Returns `true` if an instance of the singleton exists. |
| `Instance` | `T` | The instance of the singleton. |

## Methods

### `OnStartClient(bool IsOwner)`

Called when the client starts.

**Parameters:**

* `IsOwner`: If `true`, the client is the owner of the object.
