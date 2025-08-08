# SupplierStash

The `SupplierStash` class represents a supplier's stash. It is responsible for managing the cash in the stash and allowing the player to pay off their debt to the supplier.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `locationDescription` | `string` | A description of the location of the stash. |
| `Supplier` | `Supplier` | The supplier that owns the stash. |
| `Storage` | `StorageEntity` | The storage entity for the stash. |
| `IntObj` | `InteractableObject` | The interactable object for the stash. |
| `Light` | `OptimizedLight` | The light for the stash. |
| `StashPoI` | `POI` | The point of interest for the stash. |
| `CashAmount` | `float` | The amount of cash in the stash. |

## Methods

### `RemoveCash(float amount)`

Removes a specified amount of cash from the stash.

**Parameters:**

* `amount`: The amount of cash to remove.
