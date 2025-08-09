# Condition

The `Condition` class is used to evaluate a condition against a variable in the `VariableDatabase`.

## Enums

### EConditionType

This enum defines the different types of conditions.

-   `GreaterThan`
-   `LessThan`
-   `EqualTo`
-   `NotEqualTo`
-   `GreaterThanOrEqualTo`
-   `LessThanOrEqualTo`

## Public Properties

| Property       | Type           | Description                                      |
| -------------- | -------------- | ------------------------------------------------ |
| `VariableName` | `string`       | The name of the variable to check.               |
| `Operator`     | `EConditionType` | The operator to use for the comparison.          |
| `Value`        | `string`       | The value to compare against.                    |

## Public Methods

| Method      | Return Type | Description                                      |
| ----------- | ----------- | ------------------------------------------------ |
| `Evaluate()` | `bool`      | Evaluates the condition and returns true if it is met. |
