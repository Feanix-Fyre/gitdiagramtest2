# QuestCondition

The `QuestCondition` class is used to check if a quest is in a certain state. It can check the state of the quest itself, or the state of a specific entry in the quest.

## Public Properties

| Property               | Type        | Description                                      |
| ---------------------- | ----------- | ------------------------------------------------ |
| `CheckQuestState`      | `bool`      | If true, the state of the quest will be checked. |
| `QuestName`            | `string`    | The name of the quest to check.                  |
| `QuestState`           | `EQuestState` | The state the quest must be in for the condition to be true. |
| `CheckQuestEntryState` | `bool`      | If true, the state of a specific quest entry will be checked. |
| `QuestEntryIndex`      | `int`       | The index of the quest entry to check.           |
| `QuestEntryState`      | `EQuestState` | The state the quest entry must be in for the condition to be true. |

## Public Methods

| Method      | Return Type | Description                                      |
| ----------- | ----------- | ------------------------------------------------ |
| `Evaluate()` | `bool`      | Evaluates the condition and returns true if it is met. |
