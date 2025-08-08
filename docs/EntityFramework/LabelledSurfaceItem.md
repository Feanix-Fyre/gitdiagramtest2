# LabelledSurfaceItem

The `LabelledSurfaceItem` class represents a surface item that has a label. It inherits from the `SurfaceItem` class.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `MaxCharacters` | `int` | The maximum number of characters that can be in the label. |
| `Label` | `TextMeshPro` | The text mesh pro for the label. |
| `Message` | `string` | The message of the label. |

## Methods

### `SendMessageToServer(string message)`

Sends a message to the server to update the label.

**Parameters:**

* `message`: The message to send.

### `SetMessage(NetworkConnection conn, string message)`

Sets the message of the label.

**Parameters:**

* `conn`: The network connection.
* `message`: The message to set.

### `Interacted()`

Called when the player interacts with the label.

### `GetSaveString()`

Gets the save string for the labelled surface item.

**Returns:** `string`
