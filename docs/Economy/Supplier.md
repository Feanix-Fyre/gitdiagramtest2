# Supplier

The `Supplier` class represents a supplier NPC in the game. It inherits from the `NPC` class. It is responsible for managing the supplier's relationship with the player, their inventory, and their deals.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `SupplierLabelColor` | `Color32` | The color of the supplier's label. |
| `MinOrderLimit` | `float` | The minimum order limit for the supplier. |
| `MaxOrderLimit` | `float` | The maximum order limit for the supplier. |
| `OnlineShopItems` | `PhoneShopInterface.Listing[]` | An array of items that the supplier sells in their online shop. |
| `SupplierRecommendMessage` | `string` | The message that the supplier will send to the player when they recommend another NPC. |
| `SupplierUnlockHint` | `string` | The hint that will be displayed to the player when they unlock the supplier. |
| `Shop` | `ShopInterface` | The shop interface for the supplier. |
| `Stash` | `SupplierStash` | The supplier's stash. |
| `onDeaddropReady` | `UnityEvent` | An event that is invoked when a dead drop is ready. |
| `Status` | `ESupplierStatus` | The status of the supplier. |
| `DeliveriesEnabled` | `bool` | Returns `true` if the supplier has deliveries enabled. |
| `Debt` | `float` | The amount of debt that the player owes to the supplier. |
| `minsUntilDeaddropReady` | `int` | The number of minutes until the next dead drop is ready. |

## Methods

### `SendUnlocked()`

Sends an RPC to all clients to unlock the supplier.

### `MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)`

Meets the player at a location.

**Parameters:**

* `conn`: The network connection to meet the player on.
* `locationIndex`: The index of the location to meet at.
* `expireIn`: The number of minutes until the meeting expires.

### `EndMeeting()`

Ends the current meeting.

### `SetUnlockMessage()`

Sets the unlock message for the supplier.

### `GetDeadDropLimit()`

Gets the dead drop limit for the supplier.

**Returns:** `float`

### `GetSaveString()`

Gets the save string for the supplier data.

**Returns:** `string`

### `Load(NPCData data, string containerPath)`

Loads the supplier data.

**Parameters:**

* `data`: The NPC data to load.
* `containerPath`: The path to the container.
