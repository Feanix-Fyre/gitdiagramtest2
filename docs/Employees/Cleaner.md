# Cleaner

The `Cleaner` class represents a cleaner employee. It inherits from the `Employee` class and implements the `IConfigurable` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `TrashGrabberDef` | `TrashGrabberDefinition` | The definition for the trash grabber. |
| `PickUpTrashBehaviour` | `PickUpTrashBehaviour` | The behaviour for picking up trash. |
| `EmptyTrashGrabberBehaviour` | `EmptyTrashGrabberBehaviour` | The behaviour for emptying the trash grabber. |
| `BagTrashCanBehaviour` | `BagTrashCanBehaviour` | The behaviour for bagging a trash can. |
| `DisposeTrashBagBehaviour` | `DisposeTrashBagBehaviour` | The behaviour for disposing a trash bag. |
| `typeIcon` | `Sprite` | The icon for the cleaner. |
| `WorldspaceUIPrefab` | `CleanerUIElement` | The prefab for the worldspace UI. |
| `uiPoint` | `Transform` | The point where the UI will be displayed. |
| `trashGrabberInstance` | `TrashGrabberInstance` | The instance of the trash grabber. |
| `Configuration` | `EntityConfiguration` | The configuration for the cleaner. |
| `ConfigReplicator` | `ConfigurationReplicator` | The configuration replicator for the cleaner. |
| `ConfigurableType` | `EConfigurableType` | The configurable type of the cleaner. |
| `WorldspaceUI` | `WorldspaceUIElement` | The worldspace UI for the cleaner. |
| `CurrentPlayerConfigurer` | `NetworkObject` | The player who is currently configuring the cleaner. |
| `TypeIcon` | `Sprite` | The icon for the cleaner. |
| `Transform` | `Transform` | The transform of the cleaner. |
| `UIPoint` | `Transform` | The point where the UI will be displayed. |
| `CanBeSelected` | `bool` | Returns `true` if the cleaner can be selected. |
| `ParentProperty` | `Property` | The parent property of the cleaner. |

## Methods

### `SetConfigurer(NetworkObject player)`

Sets the player who is currently configuring the cleaner.

**Parameters:**

* `player`: The player to set as the configurer.

### `SendConfigurationToClient(NetworkConnection conn)`

Sends the configuration to a client.

**Parameters:**

* `conn`: The client to send the configuration to.

### `GetBed()`

Gets the bed that the cleaner is assigned to.

**Returns:** `BedItem`

### `CreateWorldspaceUI()`

Creates the worldspace UI for the cleaner.

**Returns:** `WorldspaceUIElement`

### `DestroyWorldspaceUI()`

Destroys the worldspace UI for the cleaner.

### `GetSaveString()`

Gets the save string for the cleaner.

**Returns:** `string`

### `WriteData(string parentFolderPath)`

Writes the cleaner data to a file.

**Parameters:**

* `parentFolderPath`: The path to the parent folder.

**Returns:** `List<string>`
