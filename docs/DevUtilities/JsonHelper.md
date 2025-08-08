# JsonHelper

The `JsonHelper` class is a static utility class that provides methods for working with JSON.

## Methods

### `FromJson<T>(string json)`

Converts a JSON string to an array of objects.

**Parameters:**

* `json`: The JSON string to convert.

**Returns:** `T[]`

### `ToJson<T>(T[] array)`

Converts an array of objects to a JSON string.

**Parameters:**

* `array`: The array to convert.

**Returns:** `string`

### `ToJson<T>(T[] array, bool prettyPrint)`

Converts an array of objects to a JSON string.

**Parameters:**

* `array`: The array to convert.
* `prettyPrint`: If `true`, the JSON string will be pretty-printed.

**Returns:** `string`
