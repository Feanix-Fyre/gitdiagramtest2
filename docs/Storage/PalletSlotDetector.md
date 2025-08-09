# PalletSlotDetector

The `PalletSlotDetector` class is a simple component that detects when a collider stays within its trigger. It is used by the `Pallet` class to detect when an item is placed on it.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `pallet` | `Pallet` | The pallet that this detector belongs to. |

## Methods

### `OnTriggerStay(Collider other)`

Called when a collider stays within the trigger.

**Parameters:**

* `other`: The collider that is staying within the trigger.
