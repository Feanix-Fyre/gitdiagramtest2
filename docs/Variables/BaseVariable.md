# BaseVariable

The `BaseVariable` class is an abstract base class for all variables in the game. It defines the basic properties of a variable, such as its name, replication mode, persistence, and owner. It also defines abstract methods for getting and setting the variable's value, as well as for replicating the value over the network.

## Public Properties

| Property        | Type                       | Description                                      |
| --------------- | -------------------------- | ------------------------------------------------ |
| `ReplicationMode` | `EVariableReplicationMode` | The replication mode of the variable.            |
| `Name`          | `string`                   | The name of the variable.                        |
| `Persistent`    | `bool`                     | A boolean that indicates whether the variable is persistent. |
| `VariableMode`  | `EVariableMode`            | The mode of the variable.                        |
| `Owner`         | `Player`                   | The owner of the variable.                       |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `GetValue()`                                | `object`    | Gets the value of the variable.                  |
| `SetValue(object value, bool replicate = true)` | `void`      | Sets the value of the variable.                  |
| `ReplicateValue(NetworkConnection conn)`    | `void`      | Replicates the value of the variable to the server or a client. |
| `EvaluateCondition(Condition.EConditionType operation, string value)` | `bool` | Evaluates a condition against the variable's value. |
