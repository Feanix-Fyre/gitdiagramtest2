# DialogueHandler_VehicleSalesman

The `DialogueHandler_VehicleSalesman` class is a dialogue handler for a vehicle salesman. It inherits from the `ControlledDialogueHandler` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Salesman` | `Jeremy` | The salesman that this dialogue handler is for. |
| `selectedVehicle` | `Jeremy.DealershipListing` | The vehicle that the player has selected. |

## Methods

### `ModifyChoiceText(string choiceLabel, string choiceText)`

Modifies the text of a dialogue choice.

**Parameters:**

* `choiceLabel`: The label of the dialogue choice.
* `choiceText`: The text of the dialogue choice.

**Returns:** `string`

### `CheckChoice(string choiceLabel, out string invalidReason)`

Checks if a choice is valid.

**Parameters:**

* `choiceLabel`: The label of the choice to check.
* `invalidReason`: Returns the reason why the choice is invalid.

**Returns:** `bool`
