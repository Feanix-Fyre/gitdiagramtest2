# PositionHistoryTracker

The `PositionHistoryTracker` class is a component that tracks the position of a game object over time.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `recordingFrequency` | `float` | The frequency (in seconds) to record the position. |
| `historyDuration` | `float` | The duration (in seconds) to store the position history. |
| `positionHistory` | `List<Vector3>` | A list of all recorded positions. |
| `RecordedTime` | `float` | The total time that has been recorded. |

## Methods

### `GetPositionXSecondsAgo(float secondsAgo)`

Gets the position of the game object a certain number of seconds ago.

**Parameters:**

* `secondsAgo`: The number of seconds ago to get the position from.

**Returns:** `Vector3`

### `ClearHistory()`

Clears the position history.
