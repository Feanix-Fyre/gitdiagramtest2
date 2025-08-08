# ToggleableItem

The `ToggleableItem` class represents a grid item that can be toggled on and off. It inherits from the `GridItem` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `StartupAction` | `EStartupAction` | The action to perform on startup. |
| `onTurnedOn` | `UnityEvent` | An event that is invoked when the item is turned on. |
| `onTurnedOff` | `UnityEvent` | An event that is invoked when the item is turned off. |
| `onTurnOnOrOff` | `UnityEvent` | An event that is invoked when the item is turned on or off. |
| `IsOn` | `bool` | Returns `true` if the item is on. |

## Methods

### `Toggle()`

Toggles the item on or off.

### `TurnOn(bool network = true)`

Turns the item on.

**Parameters:**

* `network`: If `true`, the item will be turned on over the network.

### `TurnOff(bool network = true)`

Turns the item off.

**Parameters:**

* `network`: If `true`, the item will be turned off over the network.

### `GetSaveString()`

Gets the save string for the toggleable item.

**Returns:** `string`

---

# EStartupAction

The `EStartupAction` enum defines the different startup actions for a toggleable item.

## Values

| Name | Description |
| --- | --- |
| `None` | No startup action. |
| `TurnOn` | Turn the item on. |
| `TurnOff` | Turn the item off. |
| `Toggle` | Toggle the item. |
