# DialogueModule

The `DialogueModule` class represents a module of dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ModuleType` | `EDialogueModule` | The type of the dialogue module. |
| `Entries` | `List<Entry>` | A list of all entries in the dialogue module. |

## Methods

### `GetEntry(string key)`

Gets an entry by its key.

**Parameters:**

* `key`: The key of the entry to get.

**Returns:** `Entry`

### `GetChain(string key)`

Gets a dialogue chain from an entry.

**Parameters:**

* `key`: The key of the entry to get the chain from.

**Returns:** `DialogueChain`

### `HasChain(string key)`

Returns `true` if an entry has a dialogue chain.

**Parameters:**

* `key`: The key of the entry to check.

**Returns:** `bool`

### `GetLine(string key)`

Gets a dialogue line from an entry.

**Parameters:**

* `key`: The key of the entry to get the line from.

**Returns:** `string`
