# Chemist

The `Chemist` class represents a chemist employee. It inherits from the `Employee` class and implements the `IConfigurable` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `typeIcon` | `Sprite` | The icon for the chemist. |
| `StartChemistryStationBehaviour` | `StartChemistryStationBehaviour` | The behaviour for starting a chemistry station. |
| `StartLabOvenBehaviour` | `StartLabOvenBehaviour` | The behaviour for starting a lab oven. |
| `FinishLabOvenBehaviour` | `FinishLabOvenBehaviour` | The behaviour for finishing a lab oven. |
| `StartCauldronBehaviour` | `StartCauldronBehaviour` | The behaviour for starting a cauldron. |
| `StartMixingStationBehaviour` | `StartMixingStationBehaviour` | The behaviour for starting a mixing station. |
| `WorldspaceUIPrefab` | `ChemistUIElement` | The prefab for the worldspace UI. |
| `uiPoint` | `Transform` | The point where the UI will be displayed. |
| `Configuration` | `EntityConfiguration` | The configuration for the chemist. |
| `ConfigReplicator` | `ConfigurationReplicator` | The configuration replicator for the chemist. |
| `ConfigurableType` | `EConfigurableType` | The configurable type of the chemist. |
| `WorldspaceUI` | `WorldspaceUIElement` | The worldspace UI for the chemist. |
| `CurrentPlayerConfigurer` | `NetworkObject` | The player who is currently configuring the chemist. |
| `TypeIcon` | `Sprite` | The icon for the chemist. |
| `Transform` | `Transform` | The transform of the chemist. |
| `UIPoint` | `Transform` | The point where the UI will be displayed. |
| `CanBeSelected` | `bool` | Returns `true` if the chemist can be selected. |
| `ParentProperty` | `Property` | The parent property of the chemist. |

## Methods

### `SetConfigurer(NetworkObject player)`

Sets the player who is currently configuring the chemist.

**Parameters:**

* `player`: The player to set as the configurer.

### `SendConfigurationToClient(NetworkConnection conn)`

Sends the configuration to a client.

**Parameters:**

* `conn`: The client to send the configuration to.

### `GetBed()`

Gets the bed that the chemist is assigned to.

**Returns:** `BedItem`

### `GetLabOvensReadyToFinish()`

Gets a list of lab ovens that are ready to be finished.

**Returns:** `List<LabOven>`

### `GetLabOvensReadyToStart()`

Gets a list of lab ovens that are ready to be started.

**Returns:** `List<LabOven>`

### `GetChemistryStationsReadyToStart()`

Gets a list of chemistry stations that are ready to be started.

**Returns:** `List<ChemistryStation>`

### `GetCauldronsReadyToStart()`

Gets a list of cauldrons that are ready to be started.

**Returns:** `List<Cauldron>`

### `GetMixingStationsReadyToStart()`

Gets a list of mixing stations that are ready to be started.

**Returns:** `List<MixingStation>`

### `CreateWorldspaceUI()`

Creates the worldspace UI for the chemist.

**Returns:** `WorldspaceUIElement`

### `DestroyWorldspaceUI()`

Destroys the worldspace UI for the chemist.

### `GetSaveString()`

Gets the save string for the chemist.

**Returns:** `string`

### `WriteData(string parentFolderPath)`

Writes the chemist data to a file.

**Parameters:**

* `parentFolderPath`: The path to the parent folder.

**Returns:** `List<string>`
