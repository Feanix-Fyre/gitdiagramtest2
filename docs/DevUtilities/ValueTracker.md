# ValueTracker

The `ValueTracker` class is a class that tracks a value over time.

## Constructors

### `ValueTracker(float HistoryDuration)`

Initializes a new instance of the `ValueTracker` class.

**Parameters:**

* `HistoryDuration`: The duration of the history to track.

## Methods

### `Destroy()`

Destroys the value tracker.

### `Update()`

Updates the value tracker.

### `SubmitValue(float value)`

Submits a value to the value tracker.

**Parameters:**

* `value`: The value to submit.

### `RecordedHistoryLength()`

Gets the length of the recorded history.

**Returns:** `float`

### `GetLowestValue()`

Gets the lowest value in the history.

**Returns:** `float`

### `GetAverageValue()`

Gets the average value in the history.

**Returns:** `float`
