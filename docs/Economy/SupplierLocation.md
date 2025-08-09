# SupplierLocation

The `SupplierLocation` class represents a location where a supplier can be found.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `AllLocations` | `List<SupplierLocation>` | A list of all supplier locations. |
| `LocationName` | `string` | The name of the location. |
| `LocationDescription` | `string` | A description of the location. |
| `GenericContainer` | `Transform` | A generic container for the location. |
| `SupplierStandPoint` | `Transform` | The point where the supplier will stand. |
| `DeliveryBays` | `WorldStorageEntity[]` | An array of delivery bays at the location. |
| `PoI` | `POI` | The point of interest for the location. |
| `IsOccupied` | `bool` | Returns `true` if the location is occupied by a supplier. |
| `ActiveSupplier` | `Supplier` | The supplier that is currently at the location. |

## Methods

### `SetActiveSupplier(Supplier supplier)`

Sets the active supplier at the location.

**Parameters:**

* `supplier`: The supplier to set as active.
