# Variable<T>

The `Variable<T>` class is a generic base class for variables in the game. It inherits from `BaseVariable` and adds a generic `Value` property. It also has an `OnValueChanged` event that is invoked when the value of the variable changes.

## Public Properties

| Property       | Type            | Description                                      |
| -------------- | --------------- | ------------------------------------------------ |
| `Value`        | `T`             | The value of the variable.                       |
| `OnValueChanged` | `UnityEvent<T>` | An event that is invoked when the value of the variable changes. |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `GetValue()`                                | `object`    | Gets the value of the variable.                  |
| `SetValue(object value, bool replicate)`    | `void`      | Sets the value of the variable.                  |
| `TryDeserialize(string valueString, out T value)` | `bool`      | Tries to deserialize a string into a value of type `T`. |
| `ReplicateValue(NetworkConnection conn)`    | `void`      | Replicates the value of the variable to the server or a client. |
