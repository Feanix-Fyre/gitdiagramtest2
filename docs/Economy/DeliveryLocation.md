# DeliveryLocation

The `DeliveryLocation` class represents a location where a delivery can be made. It implements the `IGUIDRegisterable` interface.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `LocationName` | `string` | The name of the delivery location. |
| `LocationDescription` | `string` | A description of the delivery location. |
| `CustomerStandPoint` | `Transform` | The point where the customer will stand. |
| `TeleportPoint` | `Transform` | The point where the player will be teleported to when they arrive at the location. |
| `PoI` | `POI` | The point of interest for the delivery location. |
| `StaticGUID` | `string` | The static GUID of the delivery location. |
| `ScheduledContracts` | `List<Contract>` | A list of contracts that are scheduled for this delivery location. |
| `GUID` | `Guid` | The GUID of the delivery location. |

## Methods

### `SetGUID(Guid guid)`

Sets the GUID of the delivery location.

**Parameters:**

* `guid`: The GUID to set.

### `GetDescription()`

Gets the description of the delivery location.

**Returns:** `string`
