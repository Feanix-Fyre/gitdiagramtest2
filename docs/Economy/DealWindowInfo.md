# DealWindowInfo

The `DealWindowInfo` struct represents a time window in which a deal can take place.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `StartTime` | `int` | The start time of the deal window. |
| `EndTime` | `int` | The end time of the deal window. |
| `Morning` | `DealWindowInfo` | The morning deal window. |
| `Afternoon` | `DealWindowInfo` | The afternoon deal window. |
| `Night` | `DealWindowInfo` | The night deal window. |
| `LateNight` | `DealWindowInfo` | The late night deal window. |

## Constructors

### `DealWindowInfo(int startTime, int endTime)`

Initializes a new instance of the `DealWindowInfo` struct.

**Parameters:**

* `startTime`: The start time of the deal window.
* `endTime`: The end time of the deal window.

## Methods

### `GetWindowInfo(EDealWindow window)`

Gets the deal window info for a given deal window.

**Parameters:**

* `window`: The deal window to get the info for.

**Returns:** `DealWindowInfo`

### `GetWindow(int time)`

Gets the deal window for a given time.

**Parameters:**

* `time`: The time to get the deal window for.

**Returns:** `EDealWindow`
