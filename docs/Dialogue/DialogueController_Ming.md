# DialogueController_Ming

The `DialogueController_Ming` class is a dialogue controller for the character Ming. It inherits from the `DialogueController` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Property` | `Property` | The property that Ming is selling. |
| `Price` | `float` | The price of the property. |
| `BuyDialogue` | `DialogueContainer` | The dialogue container for buying the property. |
| `BuyText` | `string` | The text for the buy choice. |
| `RemindText` | `string` | The text for the remind choice. |
| `RemindLocationDialogue` | `DialogueContainer` | The dialogue container for reminding the player of the property's location. |
| `PurchaseRoomQuests` | `QuestEntry[]` | An array of quests that must be completed before the player can purchase the room. |
| `onPurchase` | `UnityEvent` | An event that is invoked when the player purchases the property. |

## Methods

### `ModifyChoiceText(string choiceLabel, string choiceText)`

Modifies the text of a dialogue choice.

**Parameters:**

* `choiceLabel`: The label of the dialogue choice.
* `choiceText`: The text of the dialogue choice.

**Returns:** `string`

### `ModifyDialogueText(string dialogueLabel, string dialogueText)`

Modifies the text of a dialogue node.

**Parameters:**

* `dialogueLabel`: The label of the dialogue node.
* `dialogueText`: The text of the dialogue node.

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
