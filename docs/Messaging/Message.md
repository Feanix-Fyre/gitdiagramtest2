# Message

The `Message` class represents a single message in a conversation.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `messageId` | `int` | The ID of the message. |
| `text` | `string` | The text of the message. |
| `sender` | `ESenderType` | The sender of the message. |
| `endOfGroup` | `bool` | If `true`, this message is the end of a group of messages. |

## Constructors

### `Message()`

Initializes a new instance of the `Message` class.

### `Message(string _text, ESenderType _type, bool _endOfGroup = false, int _messageId = -1)`

Initializes a new instance of the `Message` class.

**Parameters:**

* `_text`: The text of the message.
* `_type`: The sender of the message.
* `_endOfGroup`: If `true`, this message is the end of a group of messages.
* `_messageId`: The ID of the message.

### `Message(TextMessageData data)`

Initializes a new instance of the `Message` class from a `TextMessageData` object.

**Parameters:**

* `data`: The `TextMessageData` object to initialize the message from.

## Methods

### `GetSaveData()`

Gets the save data for the message.

**Returns:** `TextMessageData`
