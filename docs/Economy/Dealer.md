# Dealer

The `Dealer` class represents a dealer NPC in the game. It inherits from the `NPC` class and implements the `IItemSlotOwner` interface. It is responsible for managing the dealer's relationship with the player, their inventory, and their deals.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onDealerRecruited` | `Action<Dealer>` | An event that is invoked when a dealer is recruited. |
| `DealerLabelColor` | `Color32` | The color of the dealer's label. |
| `AllDealers` | `List<Dealer>` | A list of all dealers in the game. |
| `InitialCustomers` | `List<Customer>` | A list of the dealer's initial customers. |
| `InitialItems` | `List<ProductDefinition>` | A list of the dealer's initial items. |
| `Home` | `NPCEnterableBuilding` | The dealer's home. |
| `DealSignal` | `NPCSignal_HandleDeal` | The deal signal for the dealer. |
| `HomeEvent` | `NPCEvent_StayInBuilding` | The home event for the dealer. |
| `DialogueController` | `DialogueController_Dealer` | The dialogue controller for the dealer. |
| `RecruitDialogue` | `DialogueContainer` | The dialogue container for recruiting the dealer. |
| `CollectCashDialogue` | `DialogueContainer` | The dialogue container for collecting cash from the dealer. |
| `AssignCustomersDialogue` | `DialogueContainer` | The dialogue container for assigning customers to the dealer. |
| `HomeName` | `string` | The name of the dealer's home. |
| `SigningFee` | `float` | The signing fee for recruiting the dealer. |
| `Cut` | `float` | The dealer's cut of the profits. |
| `SellInsufficientQualityItems` | `bool` | If `true`, the dealer will sell items of insufficient quality. |
| `SellExcessQualityItems` | `bool` | If `true`, the dealer will sell items of excess quality. |
| `CompletedDealsVariable` | `string` | The name of the variable that stores the number of completed deals. |
| `AssignedCustomers` | `List<Customer>` | A list of customers that are assigned to the dealer. |
| `ActiveContracts` | `List<Contract>` | A list of active contracts for the dealer. |
| `onRecommended` | `UnityEvent` | An event that is invoked when the dealer is recommended. |
| `IsRecruited` | `bool` | Returns `true` if the dealer has been recruited. |
| `ItemSlots` | `List<ItemSlot>` | The list of item slots for the dealer. |
| `Cash` | `float` | The amount of cash that the dealer has. |
| `HasBeenRecommended` | `bool` | Returns `true` if the dealer has been recommended. |
| `potentialDealerPoI` | `NPCPoI` | The point of interest for the potential dealer. |
| `dealerPoI` | `NPCPoI` | The point of interest for the dealer. |

## Methods

### `MarkAsRecommended()`

Marks the dealer as recommended.

### `InitialRecruitment()`

Initializes the recruitment of the dealer.

### `SetIsRecruited(NetworkConnection conn)`

Sets whether the dealer has been recruited.

**Parameters:**

* `conn`: The network connection to set the recruited status on.

### `SendAddCustomer(string npcID)`

Sends an RPC to all clients to add a customer to the dealer.

**Parameters:**

* `npcID`: The ID of the NPC to add as a customer.

### `RemoveCustomer(Customer customer)`

Removes a customer from the dealer.

**Parameters:**

* `customer`: The customer to remove.

### `ChangeCash(float change)`

Changes the amount of cash that the dealer has.

**Parameters:**

* `change`: The amount to change the cash by.

### `SetCash(float cash)`

Sets the amount of cash that the dealer has.

**Parameters:**

* `cash`: The amount of cash to set.

### `CompletedDeal()`

Called when a deal is completed.

### `SubmitPayment(float payment)`

Submits a payment to the dealer.

**Parameters:**

* `payment`: The payment to submit.

### `GetOrderableProducts()`

Gets a list of products that can be ordered from the dealer.

**Returns:** `List<ProductDefinition>`

### `GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)`

Gets the number of products of a certain type that the dealer has.

**Parameters:**

* `productID`: The ID of the product to get the count of.
* `minQuality`: The minimum quality of the product.
* `maxQuality`: The maximum quality of the product.

**Returns:** `int`

### `RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)`

Removes the items for a contract from the dealer's inventory.

**Parameters:**

* `contract`: The contract to remove the items for.
* `targetQuality`: The target quality of the items.
* `items`: Returns a list of the items that were removed.

**Returns:** `bool`

### `GetAllSlots()`

Gets a list of all item slots for the dealer.

**Returns:** `List<ItemSlot>`

### `AddItemToInventory(ItemInstance item)`

Adds an item to the dealer's inventory.

**Parameters:**

* `item`: The item to add.

### `TryMoveOverflowItems()`

Tries to move items from the overflow slots to the main inventory.

### `GetTotalInventoryItemCount()`

Gets the total number of items in the dealer's inventory.

**Returns:** `int`

### `SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)`

Sets the stored instance of an item in an item slot.

**Parameters:**

* `conn`: The network connection to set the stored instance on.
* `itemSlotIndex`: The index of the item slot.
* `instance`: The item instance to set.

### `SetItemSlotQuantity(int itemSlotIndex, int quantity)`

Sets the quantity of an item in an item slot.

**Parameters:**

* `itemSlotIndex`: The index of the item slot.
* `quantity`: The quantity to set.

### `SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)`

Sets whether an item slot is locked.

**Parameters:**

* `conn`: The network connection to set the locked status on.
* `itemSlotIndex`: The index of the item slot.
* `locked`: If `true`, the item slot will be locked.
* `lockOwner`: The network object that is locking the item slot.
* `lockReason`: The reason why the item slot is being locked.

### `GetSaveString()`

Gets the save string for the dealer data.

**Returns:** `string`

### `Load(NPCData data, string containerPath)`

Loads the dealer data.

**Parameters:**

* `data`: The NPC data to load.
* `containerPath`: The path to the container.
