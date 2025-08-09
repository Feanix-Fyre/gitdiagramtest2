# VariableDatabase

The `VariableDatabase` class is a `NetworkSingleton` that manages all the variables in the game. It can create, get, and set variables, and it also handles saving and loading of persistent variables.

## Enums

### EVariableType

This enum defines the different types of variables.

-   `Bool`: A boolean variable.
-   `Number`: A number variable.

## Public Properties

| Property                | Type                      | Description                                      |
| ----------------------- | ------------------------- | ------------------------------------------------ |
| `VariableList`          | `List<BaseVariable>`      | A list of all the variables in the database.     |
| `VariableDict`          | `Dictionary<string, BaseVariable>` | A dictionary of all the variables in the database, indexed by name. |
| `Creators`              | `VariableCreator[]`       | An array of `VariableCreator`s that are used to create the initial variables. |
| `ItemsToTrackAcquire`   | `StorableItemDefinition[]`| An array of `StorableItemDefinition`s that will have "acquired" variables created for them. |
| `SaveFileName`          | `string`                  | The name of the save file for the variables.     |
| `Loader`                | `Loader`                  | The loader to use for loading variable data.     |
| `ShouldSaveUnderFolder` | `bool`                    | A boolean that indicates whether the save file should be saved under a folder. |
| `LocalExtraFiles`       | `List<string>`            | A list of extra files to save.                   |
| `LocalExtraFolders`     | `List<string>`            | A list of extra folders to save.                 |
| `HasChanged`            | `bool`                    | A boolean that indicates whether the variable data has changed. |

## Public Methods

| Method                                      | Return Type      | Description                                                                    |
| ------------------------------------------- | ---------------- | ------------------------------------------------------------------------------ |
| `InitializeSaveable()`                      | `void`           | Initializes the saveable.                                                      |
| `CreatePlayerVariables(Player owner)`       | `void`           | Creates the player-specific variables for a player.                            |
| `CreateVariable(string name, EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = EVariableReplicationMode.Networked)` | `void` | Creates a new variable.                                                        |
| `AddVariable(BaseVariable variable)`        | `void`           | Adds a variable to the database.                                               |
| `SendValue(NetworkConnection conn, string variableName, string value)` | `void` | Sends a variable value to the server.                                          |
| `ReceiveValue(NetworkConnection conn, string variableName, string value)` | `void` | Receives a variable value from the server.                                     |
| `SetVariableValue(string variableName, string value, bool network = true)` | `void` | Sets the value of a variable.                                                  |
| `GetVariable(string variableName)`          | `BaseVariable`   | Gets a variable by its name.                                                   |
| `GetValue<T>(string variableName)`          | `T`              | Gets the value of a variable.                                                  |
| `PrintAllVariables()`                       | `void`           | Prints the values of all the variables to the console.                         |
| `PrintVariableValue(string variableName)`   | `void`           | Prints the value of a variable to the console.                                 |
| `NotifyItemAcquired(string id, int quantity)` | `void`           | Notifies the database that an item has been acquired.                          |
| `GetSaveString()`                           | `string`         | Gets the save string for all the persistent variables.                         |
| `LoadVariable(VariableData data)`           | `void`           | Loads a variable from a `VariableData` object.                                 |
