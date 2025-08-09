# VODatabaseEntry

The `VODatabaseEntry` class represents a single entry in a voice-over database. It contains a line type, an array of audio clips, and a volume multiplier.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `LineType` | `EVOLineType` | The type of the voice-over line. |
| `Clips` | `AudioClip[]` | An array of audio clips for the voice-over line. |
| `VolumeMultiplier` | `float` | The volume multiplier for the voice-over line. |

## Methods

### `GetRandomClip()`

Gets a random audio clip from the entry.

**Returns:** `AudioClip`
