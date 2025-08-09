# BoolVariable

The `BoolVariable` class inherits from `Variable<bool>` and represents a boolean variable.

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `TryDeserialize(string valueString, out bool value)` | `bool`      | Tries to deserialize a string into a boolean.    |
| `EvaluateCondition(Condition.EConditionType operation, string value)` | `bool` | Evaluates a condition against the variable's value. |
