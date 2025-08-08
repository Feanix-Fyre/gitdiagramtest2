# Entry

The `Entry` struct represents an entry in a dialogue module.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Key` | `string` | The key of the entry. |
| `Chains` | `DialogueChain[]` | An array of dialogue chains for the entry. |

## Methods

### `GetRandomChain()`

Gets a random dialogue chain from the entry.

**Returns:** `DialogueChain`

### `GetRandomLine()`

Gets a random line from a random dialogue chain from the entry.

**Returns:** `string`
