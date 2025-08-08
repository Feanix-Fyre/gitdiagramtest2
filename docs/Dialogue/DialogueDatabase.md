# DialogueDatabase

The `DialogueDatabase` class is a scriptable object that contains a database of dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Modules` | `List<DialogueModule>` | A list of all dialogue modules in the database. |
| `GenericEntries` | `List<Entry>` | A list of all generic entries in the database. |

## Methods

### `Initialize(DialogueHandler _handler)`

Initializes the dialogue database.

**Parameters:**

* `_handler`: The dialogue handler to initialize the database with.

### `GetModule(EDialogueModule moduleType)`

Gets a dialogue module by its type.

**Parameters:**

* `moduleType`: The type of the dialogue module to get.

**Returns:** `DialogueModule`

### `GetChain(EDialogueModule moduleType, string key)`

Gets a dialogue chain from a dialogue module.

**Parameters:**

* `moduleType`: The type of the dialogue module to get the chain from.
* `key`: The key of the dialogue chain to get.

**Returns:** `DialogueChain`

### `HasChain(EDialogueModule moduleType, string key)`

Returns `true` if a dialogue module has a dialogue chain with the given key.

**Parameters:**

* `moduleType`: The type of the dialogue module to check.
* `key`: The key of the dialogue chain to check for.

**Returns:** `bool`

### `GetLine(EDialogueModule moduleType, string key)`

Gets a dialogue line from a dialogue module.

**Parameters:**

* `moduleType`: The type of the dialogue module to get the line from.
* `key`: The key of the dialogue line to get.

**Returns:** `string`
