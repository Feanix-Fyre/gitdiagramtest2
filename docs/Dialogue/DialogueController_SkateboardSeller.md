# DialogueController_SkateboardSeller

The `DialogueController_SkateboardSeller` class is a dialogue controller for a skateboard seller. It inherits from the `DialogueController` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Options` | `List<Option>` | A list of all options that the skateboard seller offers. |
| `onPurchase` | `UnityEvent` | An event that is invoked when the player purchases a skateboard. |

## Methods

### `ChoiceCallback(string choiceLabel)`

Called when a choice is made in the dialogue.

**Parameters:**

* `choiceLabel`: The label of the choice that was made.

### `ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)`

Modifies the list of choices for a dialogue node.

**Parameters:**

* `dialogueLabel`: The label of the dialogue node.
* `existingChoices`: The list of existing choices.

### `CheckChoice(string choiceLabel, out string invalidReason)`

Checks if a choice is valid.

**Parameters:**

* `choiceLabel`: The label of the choice to check.
* `invalidReason`: Returns the reason why the choice is invalid.

**Returns:** `bool`

### `ModifyDialogueText(string dialogueLabel, string dialogueText)`

Modifies the text of a dialogue node.

**Parameters:**

* `dialogueLabel`: The label of the dialogue node.
* `dialogueText`: The text of the dialogue node.

**Returns:** `string`
