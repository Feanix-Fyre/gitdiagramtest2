# ATM

The `ATM` class is a network behaviour that represents an ATM. It implements the `IGUIDRegisterable` and `IGenericSaveable` interfaces.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `WeeklyDepositSum` | `float` | The total amount of money that has been deposited in the ATM this week. |
| `CashPrefab` | `CashPickup` | The prefab for the cash pickup. |
| `AccessPoint` | `Transform` | The access point for the ATM. |
| `CashSpawnPoint` | `Transform` | The spawn point for cash. |
| `Damageable` | `PhysicsDamageable` | The damageable component for the ATM. |
| `onBreak` | `UnityEvent` | An event that is invoked when the ATM is broken. |
| `onRepair` | `UnityEvent` | An event that is invoked when the ATM is repaired. |
| `IsBroken` | `bool` | Returns `true` if the ATM is broken. |
| `DaysUntilRepair` | `int` | The number of days until the ATM is repaired. |
| `isInUse` | `bool` | Returns `true` if the ATM is in use. |
| `GUID` | `Guid` | The GUID of the ATM. |

## Methods

### `RegenerateGUID()`

Regenerates the GUID of the ATM.

### `SetGUID(Guid guid)`

Sets the GUID of the ATM.

**Parameters:**

* `guid`: The GUID to set.

### `DayPass()`

Called when a day passes.

### `WeekPass()`

Called when a week passes.

### `Hovered()`

Called when the player hovers over the ATM.

### `Interacted()`

Called when the player interacts with the ATM.

### `Enter()`

Enters the ATM.

### `Exit()`

Exits the ATM.

### `Load(GenericSaveData data)`

Loads the ATM data.

**Parameters:**

* `data`: The data to load.

### `GetSaveData()`

Gets the save data for the ATM.

**Returns:** `GenericSaveData`
