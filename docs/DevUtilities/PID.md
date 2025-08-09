# PID

The `PID` class represents a PID controller.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `pFactor` | `float` | The proportional factor. |
| `iFactor` | `float` | The integral factor. |
| `dFactor` | `float` | The derivative factor. |

## Constructors

### `PID(float pFactor, float iFactor, float dFactor)`

Initializes a new instance of the `PID` class.

**Parameters:**

* `pFactor`: The proportional factor.
* `iFactor`: The integral factor.
* `dFactor`: The derivative factor.

## Methods

### `Update(float setpoint, float actual, float timeFrame)`

Updates the PID controller.

**Parameters:**

* `setpoint`: The desired value.
* `actual`: The actual value.
* `timeFrame`: The time since the last update.

**Returns:** `float`
