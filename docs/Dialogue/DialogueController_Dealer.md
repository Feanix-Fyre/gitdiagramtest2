# DialogueController_Dealer

The `DialogueController_Dealer` class is a dialogue controller for a dealer. It inherits from the `DialogueController` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Dealer` | `Dealer` | The dealer that this dialogue controller is for. |

## Methods

### `ModifyDialogueText(string dialogueLabel, string dialogueText)`

Modifies the text of a dialogue node.

**Parameters:**

* `dialogueLabel`: The label of the dialogue node.
* `dialogueText`: The text of the dialogue node.

**Returns:** `string`

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

### `ChoiceCallback(string choiceLabel)`

Called when a choice is made in the dialogue.

**Parameters:**

* `choiceLabel`: The label of the choice that was made.
