# VocalReactionDatabase

The `VocalReactionDatabase` class is a serializable class that contains a database of vocal reactions.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Entries` | `List<Entry>` | A list of all entries in the database. |

## Methods

### `GetEntry(string key)`

Gets an entry by its key.

**Parameters:**

* `key`: The key of the entry to get.

**Returns:** `Entry`

---

# Entry

The `Entry` class represents a single entry in a vocal reaction database.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Key` | `string` | The key of the entry. |
| `Reactions` | `string[]` | An array of reactions for the entry. |
| `name` | `string` | The name of the entry. |

## Methods

### `GetRandomReaction()`

Gets a random reaction from the entry.

**Returns:** `string`
