# DialogueController

The `DialogueController` class is a component that controls the flow of dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `IntObj` | `InteractableObject` | The interactable object for the dialogue. |
| `GenericDialogue` | `DialogueContainer` | The generic dialogue container. |
| `DialogueEnabled` | `bool` | If `true`, dialogue is enabled. |
| `UseDialogueBehaviour` | `bool` | If `true`, the dialogue behaviour will be used. |
| `Choices` | `List<DialogueChoice>` | A list of all dialogue choices. |
| `GreetingOverrides` | `List<GreetingOverride>` | A list of all greeting overrides. |
| `OverrideContainer` | `DialogueContainer` | The override container for the dialogue. |

## Methods

### `StartGenericDialogue(bool allowExit = true)`

Starts a generic dialogue.

**Parameters:**

* `allowExit`: If `true`, the player can exit the dialogue.

### `AddDialogueChoice(DialogueChoice data, int priority = 0)`

Adds a dialogue choice.

**Parameters:**

* `data`: The dialogue choice to add.
* `priority`: The priority of the dialogue choice.

**Returns:** `int`

### `AddGreetingOverride(GreetingOverride data)`

Adds a greeting override.

**Parameters:**

* `data`: The greeting override to add.

**Returns:** `int`

### `CanStartDialogue()`

Returns `true` if a dialogue can be started.

**Returns:** `bool`

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

### `ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)`

Modifies the list of choices for a dialogue node.

**Parameters:**

* `dialogueLabel`: The label of the dialogue node.
* `existingChoices`: The list of existing choices.

### `ChoiceCallback(string choiceLabel)`

Called when a choice is made in the dialogue.

**Parameters:**

* `choiceLabel`: The label of the choice that was made.

### `CheckChoice(string choiceLabel, out string invalidReason)`

Checks if a choice is valid.

**Parameters:**

* `choiceLabel`: The label of the choice to check.
* `invalidReason`: Returns the reason why the choice is invalid.

**Returns:** `bool`

### `SetOverrideContainer(DialogueContainer container)`

Sets the override container for the dialogue.

**Parameters:**

* `container`: The override container to set.

### `ClearOverrideContainer()`

Clears the override container for the dialogue.

### `DecideBranch(string branchLabel, out int index)`

Decides which branch to take in a dialogue.

**Parameters:**

* `branchLabel`: The label of the branch to decide on.
* `index`: Returns the index of the branch to take.

**Returns:** `bool`

### `SetDialogueEnabled(bool enabled)`

Sets whether dialogue is enabled.

**Parameters:**

* `enabled`: If `true`, dialogue is enabled.
