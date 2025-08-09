# RebindActionUI

The `RebindActionUI` class is a component that provides a UI for rebinding input actions.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `onRebind` | `Action` | An event that is invoked when an action is rebound. |
| `actionReference` | `InputActionReference` | A reference to the action that is to be rebound from the UI. |
| `bindingId` | `string` | The ID of the binding that is to be rebound. |
| `displayStringOptions` | `InputBinding.DisplayStringOptions` | The display string options for the binding. |
| `actionLabel` | `TextMeshProUGUI` | The text label that will receive the name of the action. |
| `bindingText` | `TextMeshProUGUI` | The text label that will receive the current, formatted binding string. |
| `rebindPrompt` | `TextMeshProUGUI` | The text label that will be updated with a prompt for user input. |
| `rebindOverlay` | `GameObject` | The UI that will be shown while a rebind is in progress. |
| `updateBindingUIEvent` | `UpdateBindingUIEvent` | An event that is triggered when the way the binding is displayed should be updated. |
| `startRebindEvent` | `InteractiveRebindEvent` | An event that is triggered when an interactive rebind is being initiated. |
| `stopRebindEvent` | `InteractiveRebindEvent` | An event that is triggered when an interactive rebind is complete or has been aborted. |
| `ongoingRebind` | `InputActionRebindingExtensions.RebindingOperation` | The ongoing rebind operation. |

## Methods

### `ResolveActionAndBinding(out InputAction action, out int bindingIndex)`

Resolves the action and binding index for the UI.

**Parameters:**

* `action`: Returns the action that is to be rebound.
* `bindingIndex`: Returns the index of the binding that is to be rebound.

**Returns:** `bool`

### `UpdateBindingDisplay()`

Updates the binding display.

### `ResetToDefault()`

Resets the binding to its default value.

### `StartInteractiveRebind()`

Starts an interactive rebind.
