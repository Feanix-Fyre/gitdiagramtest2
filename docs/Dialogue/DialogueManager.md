# DialogueManager

The `DialogueManager` class is a singleton that manages dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `DefaultDatabase` | `DialogueDatabase` | The default dialogue database. |
| `DefaultModules` | `List<DialogueModule>` | A list of all default dialogue modules. |

## Methods

### `Get(EDialogueModule moduleType)`

Gets a dialogue module by its type.

**Parameters:**

* `moduleType`: The type of the dialogue module to get.

**Returns:** `DialogueModule`
