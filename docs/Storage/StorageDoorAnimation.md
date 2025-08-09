# StorageDoorAnimation

The `StorageDoorAnimation` class manages the animation of a storage container's door. It can be used to open and close the door, play sounds, and activate or deactivate the item container.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ItemContainer` | `Transform` | The transform that contains the items in the storage. |
| `Anims` | `Animation[]` | An array of `Animation` components to play the door animations on. |
| `OpenAnim` | `AnimationClip` | The animation clip to play when the door opens. |
| `CloseAnim` | `AnimationClip` | The animation clip to play when the door closes. |
| `OpenSound` | `AudioSourceController` | The sound to play when the door opens. |
| `CloseSound` | `AudioSourceController` | The sound to play when the door closes. |
| `IsOpen` | `bool` | Returns `true` if the door is open. |

## Methods

### `Open()`

Opens the storage door.

### `Close()`

Closes the storage door.

### `SetIsOpen(bool open)`

Sets the state of the storage door.

**Parameters:**

* `open`: If `true`, the door will be opened. Otherwise, it will be closed.

### `OverrideState(bool open)`

Overrides the state of the door. This is useful for forcing the door to be open or closed, regardless of its current state.

**Parameters:**

* `open`: The state to override the door to.

### `ResetOverride()`

Resets the override on the door's state.
