# DialogueController_ArmsDealer

The `DialogueController_ArmsDealer` class is a dialogue controller for an arms dealer. It inherits from the `DialogueController` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `MeleeWeapons` | `List<WeaponOption>` | A list of melee weapons that the arms dealer sells. |
| `RangedWeapons` | `List<WeaponOption>` | A list of ranged weapons that the arms dealer sells. |
| `Ammo` | `List<WeaponOption>` | A list of ammo that the arms dealer sells. |

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
