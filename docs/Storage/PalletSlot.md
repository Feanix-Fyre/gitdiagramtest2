# PalletSlot

The `PalletSlot` class represents a slot where a pallet can be placed. It implements the `IGUIDRegisterable` interface, which means it can be registered with the `GUIDManager` and accessed by its GUID.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onPalletAdded` | `Action` | An action that is invoked when a pallet is added to the slot. |
| `onPalletRemoved` | `Action` | An action that is invoked when a pallet is removed from the slot. |
| `GUID` | `Guid` | The GUID of the pallet slot. |
| `occupant` | `Pallet` | The pallet that is currently occupying the slot. |

## Methods

### `SetGUID(Guid guid)`

Sets the GUID of the pallet slot.

**Parameters:**

* `guid`: The GUID to set.

### `SetOccupant(Pallet _occupant)`

Sets the occupant of the pallet slot.

**Parameters:**

* `_occupant`: The pallet to set as the occupant.
