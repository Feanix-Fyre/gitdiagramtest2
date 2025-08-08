# DealGenerationEvent

The `DealGenerationEvent` class represents an event that can generate a deal.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Enabled` | `bool` | If `true`, the event is enabled. |
| `CanBeAccepted` | `bool` | If `true`, the deal can be accepted. |
| `CanBeRejected` | `bool` | If `true`, the deal can be rejected. |
| `ApplicableDays` | `List<DayContainer>` | A list of days that the event can occur on. |
| `GenerationTime` | `int` | The time of day that the event will occur. |
| `GenerationWindowDuration` | `int` | The duration of the window in which the event can occur. |
| `ProductList` | `ProductList` | The list of products that will be included in the deal. |
| `Payment` | `float` | The payment for the deal. |
| `RelationshipRequirement` | `float` | The relationship requirement for the deal. |
| `DeliveryLocation` | `DeliveryLocation` | The delivery location for the deal. |
| `PickupScheduleGroup` | `int` | The pickup schedule group for the deal. |
| `DeliveryWindow` | `QuestWindowConfig` | The delivery window for the deal. |
| `Expires` | `bool` | If `true`, the deal will expire. |
| `ExpiresAfter` | `int` | The number of days after which the deal will expire. |

## Methods

### `GenerateContractInfo(Customer customer)`

Generates a contract info for the deal.

**Parameters:**

* `customer`: The customer that the deal is for.

**Returns:** `ContractInfo`

### `ShouldGenerate(Customer customer)`

Returns `true` if the deal should be generated for the given customer.

**Parameters:**

* `customer`: The customer to check.

**Returns:** `bool`

### `GetRandomRequestMessage()`

Gets a random request message for the deal.

**Returns:** `MessageChain`

### `ProcessMessage(MessageChain messageChain)`

Processes a message chain for the deal.

**Parameters:**

* `messageChain`: The message chain to process.

**Returns:** `MessageChain`

### `GetRejectionMessage()`

Gets a rejection message for the deal.

**Returns:** `MessageChain`

### `GetAcceptanceMessage()`

Gets an acceptance message for the deal.

**Returns:** `MessageChain`

### `GetProductStringList()`

Gets a string list of the products in the deal.

**Returns:** `string`

### `GetQualityString()`

Gets a string representation of the quality of the products in the deal.

**Returns:** `string`
