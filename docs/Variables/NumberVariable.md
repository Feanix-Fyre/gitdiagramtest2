# NumberVariable

The `NumberVariable` class inherits from `Variable<float>` and represents a number variable.

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `TryDeserialize(string valueString, out float value)` | `bool`      | Tries to deserialize a string into a float.      |
| `EvaluateCondition(Condition.EConditionType operation, string value)` | `bool` | Evaluates a condition against the variable's value. |
