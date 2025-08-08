# DialogueHandler_EstateAgent

The `DialogueHandler_EstateAgent` class is a dialogue handler for an estate agent. It inherits from the `ControlledDialogueHandler` class.

## Methods

### `CheckChoice(string choiceLabel, out string invalidReason)`

Checks if a choice is valid.

**Parameters:**

* `choiceLabel`: The label of the choice to check.
* `invalidReason`: Returns the reason why the choice is invalid.

**Returns:** `bool`

### `ShouldChoiceBeShown(string choiceLabel)`

Returns `true` if a choice should be shown.

**Parameters:**

* `choiceLabel`: The label of the choice to check.

**Returns:** `bool`
