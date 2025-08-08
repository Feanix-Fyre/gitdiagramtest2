# VehicleSelector

The `VehicleSelector` class is a singleton that provides a UI for selecting vehicles.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onClose` | `Action` | An event that is invoked when the vehicle selector is closed. |
| `isSelecting` | `bool` | Returns `true` if the vehicle selector is currently active. |

## Methods

### `StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, Func<LandVehicle, bool> filter = null)`

Starts the vehicle selection process.

**Parameters:**

* `selectionTitle`: The title of the selection screen.
* `initialSelection`: A list of initially selected vehicles.
* `_selectionLimit`: The maximum number of vehicles that can be selected.
* `_exitOnSelectionLimit`: If `true`, the selection screen will be closed when the selection limit is reached.
* `filter`: A filter to apply to the vehicles that can be selected.

### `StopSelecting()`

Stops the vehicle selection process.
