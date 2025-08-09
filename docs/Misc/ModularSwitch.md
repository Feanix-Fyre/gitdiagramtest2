# ModularSwitch

The `ModularSwitch` class represents a switch that can be toggled on and off. It is a `NetworkBehaviour`.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `isOn` | `bool` | If `true`, the switch is on. |
| `OnAudio` | `AudioSourceController` | The audio to play when the switch is turned on. |
| `OffAudio` | `AudioSourceController` | The audio to play when the switch is turned off. |
| `onToggled` | `ButtonChange` | An event that is invoked when the switch is toggled. |
| `switchedOn` | `UnityEvent` | An event that is invoked when the switch is turned on. |
| `switchedOff` | `UnityEvent` | An event that is invoked when the switch is turned off. |

## Methods

### `Hovered()`

Called when the player hovers over the switch.

### `Interacted()`

Called when the player interacts with the switch.

### `SwitchOn()`

Turns the switch on.

### `SwitchOff()`

Turns the switch off.
