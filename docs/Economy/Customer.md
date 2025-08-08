# Customer

The `Customer` class represents a customer NPC in the game. It inherits from the `NetworkBehaviour` class and implements the `ISaveable` interface. It is responsible for managing the customer's relationship with the player, their addiction level, and their purchasing habits.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onCustomerUnlocked` | `Action<Customer>` | An event that is invoked when a customer is unlocked. |
| `UnlockedCustomers` | `List<Customer>` | A list of all unlocked customers. |
| `DealSignal` | `NPCSignal_WaitForDelivery` | The deal signal for the customer. |
| `AvailableInDemo` | `bool` | If `true`, the customer will be available in the demo. |
| `DefaultDeliveryLocation` | `DeliveryLocation` | The customer's default delivery location. |
| `CanRecommendFriends` | `bool` | If `true`, the customer can recommend friends to the player. |
| `onUnlocked` | `UnityEvent` | An event that is invoked when the customer is unlocked. |
| `onDealCompleted` | `UnityEvent` | An event that is invoked when a deal is completed with the customer. |
| `onContractAssigned` | `UnityEvent<Contract>` | An event that is invoked when a contract is assigned to the customer. |
| `CurrentAddiction` | `float` | The customer's current addiction level. |
| `OfferedContractInfo` | `ContractInfo` | The contract info that has been offered to the customer. |
| `OfferedContractTime` | `GameDateTime` | The time that the contract was offered. |
| `CurrentContract` | `Contract` | The customer's current contract. |
| `IsAwaitingDelivery` | `bool` | Returns `true` if the customer is awaiting a delivery. |
| `TimeSinceLastDealCompleted` | `int` | The time since the last deal was completed with the customer. |
| `TimeSinceLastDealOffered` | `int` | The time since the last deal was offered to the customer. |
| `TimeSincePlayerApproached` | `int` | The time since the player last approached the customer. |
| `TimeSinceInstantDealOffered` | `int` | The time since an instant deal was last offered to the customer. |
| `OfferedDeals` | `int` | The number of deals that have been offered to the customer. |
| `CompletedDeliveries` | `int` | The number of deliveries that have been completed for the customer. |
| `HasBeenRecommended` | `bool` | Returns `true` if the customer has been recommended to the player. |
| `NPC` | `NPC` | The NPC component of the customer. |
| `AssignedDealer` | `Dealer` | The dealer that is assigned to the customer. |
| `CustomerData` | `CustomerData` | The customer's data. |
| `OrderableProducts` | `List<ProductDefinition>` | A list of products that the customer can order. |
| `potentialCustomerPoI` | `NPCPoI` | The point of interest for the potential customer. |
| `SaveFolderName` | `string` | The name of the folder where the save files are stored. |
| `SaveFileName` | `string` | The name of the save file. |
| `Loader` | `Loader` | The loader for the customer data. |
| `ShouldSaveUnderFolder` | `bool` | Returns `true` if the save file should be saved under a folder. |
| `LocalExtraFiles` | `List<string>` | A list of extra files to save. |
| `LocalExtraFolders` | `List<string>` | A list of extra folders to save. |
| `HasChanged` | `bool` | Returns `true` if the customer data has changed and needs to be saved. |

## Methods

### `InitializeSaveable()`

Initializes the saveable object.

### `OfferContract(ContractInfo info)`

Offers a contract to the customer.

**Parameters:**

* `info`: The contract info to offer.

### `ExpireOffer()`

Expires the current contract offer.

### `AssignContract(Contract contract)`

Assigns a contract to the customer.

**Parameters:**

* `contract`: The contract to assign.

### `SetIsAwaitingDelivery(bool awaiting)`

Sets whether the customer is awaiting a delivery.

**Parameters:**

* `awaiting`: If `true`, the customer is awaiting a delivery.

### `IsAtDealLocation()`

Returns `true` if the customer is at the deal location.

**Returns:** `bool`

### `SetPotentialCustomerPoIEnabled(bool enabled)`

Sets whether the potential customer point of interest is enabled.

**Parameters:**

* `enabled`: If `true`, the point of interest is enabled.

### `OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)`

Offers deal items to the customer.

**Parameters:**

* `items`: The items to offer.
* `offeredByPlayer`: If `true`, the items were offered by the player.
* `accepted`: Returns `true` if the customer accepted the deal.

### `CustomerRejectedDeal(bool offeredByPlayer)`

Called when the customer rejects a deal.

**Parameters:**

* `offeredByPlayer`: If `true`, the deal was offered by the player.

### `ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)`

Processes a handover.

**Parameters:**

* `outcome`: The outcome of the handover.
* `contract`: The contract for the handover.
* `items`: The items that were handed over.
* `handoverByPlayer`: If `true`, the handover was done by the player.
* `giveBonuses`: If `true`, bonuses will be given for the handover.

### `ContractWellReceived(string npcToRecommend)`

Called when a contract is well received.

**Parameters:**

* `npcToRecommend`: The NPC to recommend to the player.

### `CurrentContractEnded(EQuestState outcome)`

Called when the current contract ends.

**Parameters:**

* `outcome`: The outcome of the contract.

### `EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount)`

Evaluates a delivery.

**Parameters:**

* `contract`: The contract for the delivery.
* `providedItems`: The items that were provided for the delivery.
* `highestAddiction`: Returns the highest addiction level of the products in the delivery.
* `mainTypeType`: Returns the main drug type of the products in the delivery.
* `matchedProductCount`: Returns the number of products in the delivery that matched the contract.

**Returns:** `float`

### `ChangeAddiction(float change)`

Changes the customer's addiction level.

**Parameters:**

* `change`: The amount to change the addiction level by.

### `RequestProduct()`

Requests a product from the player.

### `RequestProduct(Player target)`

Requests a product from a player.

**Parameters:**

* `target`: The player to request a product from.

### `PlayerRejectedProductRequest()`

Called when the player rejects a product request.

### `RejectProductRequestOffer()`

Rejects a product request offer.

### `AssignDealer(Dealer dealer)`

Assigns a dealer to the customer.

**Parameters:**

* `dealer`: The dealer to assign.

### `GetSaveString()`

Gets the save string for the customer data.

**Returns:** `string`

### `GetCustomerData()`

Gets the customer data.

**Returns:** `CustomerData`

### `WriteData(string parentFolderPath)`

Writes the customer data to a file.

**Parameters:**

* `parentFolderPath`: The path to the parent folder.

**Returns:** `List<string>`

### `Load(CustomerData data)`

Loads the customer data.

**Parameters:**

* `data`: The customer data to load.

### `HandoverChosen()`

Called when the handover choice is chosen in the dialogue.

### `IsUnlockable()`

Returns `true` if the customer is unlockable.

**Returns:** `bool`

### `KnownAndRecommended()`

Returns `true` if the customer is known and recommended.

**Returns:** `bool`

### `SampleOffered()`

Called when a sample is offered to the customer.

### `GetProductEnjoyment(ProductDefinition product, EQuality quality)`

Gets the customer's enjoyment of a product.

**Parameters:**

* `product`: The product to get the enjoyment of.
* `quality`: The quality of the product.

**Returns:** `float`

### `GetOrderedDrugTypes()`

Gets a list of drug types that the customer has ordered.

**Returns:** `List<EDrugType>`

### `AdjustAffinity(EDrugType drugType, float change)`

Adjusts the customer's affinity for a drug type.

**Parameters:**

* `drugType`: The drug type to adjust the affinity for.
* `change`: The amount to change the affinity by.

### `AutocreateCustomerSettings()`

Autocreates the customer settings.
