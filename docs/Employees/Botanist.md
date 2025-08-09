# Botanist

The `Botanist` class represents a botanist employee. It inherits from the `Employee` class and implements the `IConfigurable` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `typeIcon` | `Sprite` | The icon for the botanist. |
| `PotActionBehaviour` | `PotActionBehaviour` | The behaviour for performing actions on pots. |
| `StartDryingRackBehaviour` | `StartDryingRackBehaviour` | The behaviour for starting a drying rack. |
| `StopDryingRackBehaviour` | `StopDryingRackBehaviour` | The behaviour for stopping a drying rack. |
| `WorldspaceUIPrefab` | `BotanistUIElement` | The prefab for the worldspace UI. |
| `uiPoint` | `Transform` | The point where the UI will be displayed. |
| `MaxAssignedPots` | `int` | The maximum number of pots that can be assigned to the botanist. |
| `NoAssignedStationsDialogue` | `DialogueContainer` | The dialogue to play when the botanist has no assigned stations. |
| `UnspecifiedPotsDialogue` | `DialogueContainer` | The dialogue to play when the botanist has unspecified pots. |
| `NullDestinationPotsDialogue` | `DialogueContainer` | The dialogue to play when the botanist has pots with no destination. |
| `MissingMaterialsDialogue` | `DialogueContainer` | The dialogue to play when the botanist is missing materials. |
| `NoPotsRequireWorkDialogue` | `DialogueContainer` | The dialogue to play when no pots require work. |
| `Configuration` | `EntityConfiguration` | The configuration for the botanist. |
| `ConfigReplicator` | `ConfigurationReplicator` | The configuration replicator for the botanist. |
| `ConfigurableType` | `EConfigurableType` | The configurable type of the botanist. |
| `WorldspaceUI` | `WorldspaceUIElement` | The worldspace UI for the botanist. |
| `CurrentPlayerConfigurer` | `NetworkObject` | The player who is currently configuring the botanist. |
| `TypeIcon` | `Sprite` | The icon for the botanist. |
| `Transform` | `Transform` | The transform of the botanist. |
| `UIPoint` | `Transform` | The point where the UI will be displayed. |
| `CanBeSelected` | `bool` | Returns `true` if the botanist can be selected. |
| `ParentProperty` | `Property` | The parent property of the botanist. |

## Methods

### `SetConfigurer(NetworkObject player)`

Sets the player who is currently configuring the botanist.

**Parameters:**

* `player`: The player to set as the configurer.

### `SendConfigurationToClient(NetworkConnection conn)`

Sends the configuration to a client.

**Parameters:**

* `conn`: The client to send the configuration to.

### `GetBed()`

Gets the bed that the botanist is assigned to.

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

### `GetDryableInSupplies()`

Gets a dryable item from the supplies.

**Returns:** `QualityItemInstance`

### `GetItemInSupplies(string id)`

Gets an item from the supplies.

**Parameters:**

* `id`: The ID of the item to get.

**Returns:** `ItemInstance`

### `GetSeedInSupplies()`

Gets a seed from the supplies.

**Returns:** `ItemInstance`

### `CreateWorldspaceUI()`

Creates the worldspace UI for the botanist.

**Returns:** `WorldspaceUIElement`

### `DestroyWorldspaceUI()`

Destroys the worldspace UI for the botanist.

### `GetSaveString()`

Gets the save string for the botanist.

**Returns:** `string`

### `WriteData(string parentFolderPath)`

Writes the botanist data to a file.

**Parameters:**

* `parentFolderPath`: The path to the parent folder.

**Returns:** `List<string>`
