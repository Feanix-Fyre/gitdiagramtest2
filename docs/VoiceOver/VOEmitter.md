# VOEmitter

The `VOEmitter` class is responsible for playing voice-over lines. It is a component that can be attached to any game object that needs to play voice-overs.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `PitchMultiplier` | `float` | The pitch multiplier for the voice-over lines. |

## Methods

### `Play(EVOLineType lineType)`

Plays a voice-over line.

**Parameters:**

* `lineType`: The type of voice-over line to play.

### `SetRuntimePitchMultiplier(float pitchMultiplier)`

Sets the runtime pitch multiplier for the voice-over lines.

**Parameters:**

* `pitchMultiplier`: The pitch multiplier to set.

### `SetDatabase(VODatabase database, bool writeDefault = true)`

Sets the voice-over database to use.

**Parameters:**

* `database`: The voice-over database to use.
* `writeDefault`: If `true`, the new database will be set as the default database.

### `ResetDatabase()`

Resets the voice-over database to the default database.
