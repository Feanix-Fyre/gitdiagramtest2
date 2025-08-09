# Packager

The `Packager` class represents a packager employee. It inherits from the `Employee` class and implements the `IConfigurable` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `typeIcon` | `Sprite` | The icon for the packager. |
| `PackagingBehaviour` | `PackagingStationBehaviour` | The behaviour for packaging stations. |
| `BrickPressBehaviour` | `BrickPressBehaviour` | The behaviour for brick presses. |
| `WorldspaceUIPrefab` | `PackagerUIElement` | The prefab for the worldspace UI. |
| `uiPoint` | `Transform` | The point where the UI will be displayed. |
| `MaxAssignedStations` | `int` | The maximum number of stations that can be assigned to the packager. |
| `PackagingSpeedMultiplier` | `float` | The multiplier for the packaging speed. |
| `Configuration` | `EntityConfiguration` | The configuration for the packager. |
| `ConfigReplicator` | `ConfigurationReplicator` | The configuration replicator for the packager. |
| `ConfigurableType` | `EConfigurableType` | The configurable type of the packager. |
| `WorldspaceUI` | `WorldspaceUIElement` | The worldspace UI for the packager. |
| `CurrentPlayerConfigurer` | `NetworkObject` | The player who is currently configuring the packager. |
| `TypeIcon` | `Sprite` | The icon for the packager. |
| `Transform` | `Transform` | The transform of the packager. |
| `UIPoint` | `Transform` | The point where the UI will be displayed. |
| `CanBeSelected` | `bool` | Returns `true` if the packager can be selected. |
| `ParentProperty` | `Property` | The parent property of the packager. |

## Methods

### `SetConfigurer(NetworkObject player)`

Sets the player who is currently configuring the packager.

**Parameters:**

* `player`: The player to set as the configurer.

### `SendConfigurationToClient(NetworkConnection conn)`

Sends the configuration to a client.

**Parameters:**

* `conn`: The client to send the configuration to.

### `GetBed()`

Gets the bed that the packager is assigned to.

**Returns:** `BedItem`

### `CreateWorldspaceUI()`

Creates the worldspace UI for the packager.

**Returns:** `WorldspaceUIElement`

### `DestroyWorldspaceUI()`

Destroys the worldspace UI for the packager.

### `GetSaveString()`

Gets the save string for the packager.

**Returns:** `string`

### `WriteData(string parentFolderPath)`

Writes the packager data to a file.

**Parameters:**

* `parentFolderPath`: The path to the parent folder.

**Returns:** `List<string>`
