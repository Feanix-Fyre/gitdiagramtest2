# VODatabase

The `VODatabase` class is a scriptable object that contains a database of voice-over lines.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `VolumeMultiplier` | `float` | The volume multiplier for all voice-over lines in the database. |
| `Entries` | `List<VODatabaseEntry>` | A list of all voice-over line entries in the database. |

## Methods

### `GetEntry(EVOLineType lineType)`

Gets a voice-over line entry by its line type.

**Parameters:**

* `lineType`: The line type of the entry to get.

**Returns:** `VODatabaseEntry`

### `GetRandomClip(EVOLineType lineType)`

Gets a random audio clip from a voice-over line entry.

**Parameters:**

* `lineType`: The line type of the entry to get a random clip from.

**Returns:** `AudioClip`
