# CustomerData

The `CustomerData` class is a scriptable object that contains data about a customer.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `DefaultAffinityData` | `CustomerAffinityData` | The customer's default affinity data. |
| `PreferredProperties` | `List<Property>` | A list of the customer's preferred properties in a product. |
| `MinWeeklySpend` | `float` | The minimum amount of money the customer will spend in a week. |
| `MaxWeeklySpend` | `float` | The maximum amount of money the customer will spend in a week. |
| `MinOrdersPerWeek` | `int` | The minimum number of orders the customer will place in a week. |
| `MaxOrdersPerWeek` | `int` | The maximum number of orders the customer will place in a week. |
| `OrderTime` | `int` | The time of day the customer will place an order. |
| `PreferredOrderDay` | `EDay` | The customer's preferred day to place an order. |
| `Standards` | `ECustomerStandard` | The customer's standards for products. |
| `CanBeDirectlyApproached` | `bool` | If `true`, the customer can be directly approached. |
| `GuaranteeFirstSampleSuccess` | `bool` | If `true`, the first sample given to the customer will always be successful. |
| `MinMutualRelationRequirement` | `float` | The minimum mutual relationship requirement to successfully approach the customer. |
| `MaxMutualRelationRequirement` | `float` | The maximum mutual relationship requirement to successfully approach the customer. |
| `CallPoliceChance` | `float` | The chance that the customer will call the police if a direct approach fails. |
| `DependenceMultiplier` | `float` | The multiplier for how quickly the customer builds dependence. |
| `BaseAddiction` | `float` | The customer's starting addiction level. |
| `onChanged` | `Action` | An event that is invoked when the customer's data changes. |

## Methods

### `GetQualityScalar(EQuality quality)`

Gets a scalar value for a given quality level.

**Parameters:**

* `quality`: The quality level to get a scalar for.

**Returns:** `float`

### `GetOrderDays(float dependence, float normalizedRelationship)`

Gets a list of days that the customer will place an order on.

**Parameters:**

* `dependence`: The customer's dependence level.
* `normalizedRelationship`: The customer's normalized relationship level.

**Returns:** `List<EDay>`

### `GetAdjustedWeeklySpend(float normalizedRelationship)`

Gets the customer's adjusted weekly spend.

**Parameters:**

* `normalizedRelationship`: The customer's normalized relationship level.

**Returns:** `float`

### `RandomizeAffinities()`

Randomizes the customer's affinities.

### `RandomizeProperties()`

Randomizes the customer's preferred properties.

### `RandomizeTiming()`

Randomizes the customer's order timing.

### `ClearInvalid()`

Clears any invalid data from the customer's data.
