# Conditions

The `Conditions` class is used to evaluate a set of conditions. It has a list of `Condition`s and a list of `QuestCondition`s, and it can evaluate them using either an "And" or an "Or" evaluation type.

## Enums

### EEvaluationType

This enum defines the different evaluation types.

-   `And`: All conditions must be true for the evaluation to be true.
-   `Or`: At least one condition must be true for the evaluation to be true.

## Public Properties

| Property           | Type               | Description                                      |
| ------------------ | ------------------ | ------------------------------------------------ |
| `EvaluationType`   | `EEvaluationType`  | The evaluation type to use.                      |
| `ConditionList`    | `Condition[]`      | The list of `Condition`s to evaluate.            |
| `QuestConditionList`| `QuestCondition[]` | The list of `QuestCondition`s to evaluate.       |

## Public Methods

| Method      | Return Type | Description                                      |
| ----------- | ----------- | ------------------------------------------------ |
| `Evaluate()` | `bool`      | Evaluates the conditions and returns true if they are met. |
