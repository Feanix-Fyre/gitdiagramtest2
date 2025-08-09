# Response

The `Response` class represents a response to a message.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `text` | `string` | The text of the response. |
| `label` | `string` | The label of the response. |
| `callback` | `Action` | The callback to invoke when the response is chosen. |
| `disableDefaultResponseBehaviour` | `bool` | If `true`, the default response behaviour will be disabled. |

## Constructors

### `Response(string _text, string _label, Action _callback = null, bool _disableDefaultResponseBehaviour = false)`

Initializes a new instance of the `Response` class.

**Parameters:**

* `_text`: The text of the response.
* `_label`: The label of the response.
* `_callback`: The callback to invoke when the response is chosen.
* `_disableDefaultResponseBehaviour`: If `true`, the default response behaviour will be disabled.

### `Response()`

Initializes a new instance of the `Response` class.
