# Console

The `Console` class provides a developer console for executing commands at runtime. It is a singleton that manages a list of commands, their execution, and key bindings.

## Nested Classes

### `ConsoleCommand`

This is an abstract base class for all console commands. Each command must inherit from this class and implement its properties and methods.

-   **`CommandWord`**: The keyword that invokes the command.
-   **`CommandDescription`**: A brief description of what the command does.
-   **`ExampleUsage`**: An example of how to use the command.
-   **`Execute(List<string> args)`**: The method that executes the command's logic.

### Command Implementations

The `Console` class contains numerous nested classes, each implementing a specific command. Here are some examples:

-   **`SetTimeCommand`**: Sets the time of day.
-   **`SpawnVehicleCommand`**: Spawns a vehicle at the player's location.
-   **`AddItemToInventoryCommand`**: Gives an item to the player.
-   **`ClearInventoryCommand`**: Clears the player's inventory.
-   **`ChangeCashCommand`**: Modifies the player's cash balance.
-   **`SetMoveSpeedCommand`**: Sets the player's movement speed.
-   **`Teleport`**: Teleports the player to a specified location.
-   ...and many more.

Each command class overrides the properties and methods of `ConsoleCommand` to provide its specific functionality.

## Properties

-   `TeleportPointsContainer`: A `Transform` that holds the teleport destination points.
-   `LabelledGameObjectList`: A list of `LabelledGameObject` instances, which are GameObjects that can be referenced by a label in the console.
-   `startupCommands`: A list of commands to be executed on startup (editor only).
-   `Commands`: A static list of all available console commands.

## Methods

### `Awake()`

Initializes the console by populating the list of available commands.

### `RunStartupCommands()`

Executes the commands listed in `startupCommands` on startup (editor only).

### `Log(object message, Object context = null)`

Logs a message to the console.

### `LogWarning(object message, Object context = null)`

Logs a warning message to the console.

### `LogError(object message, Object context = null)`

Logs an error message to the console.

### `SubmitCommand(List<string> args)`

Submits a command for execution, parsing the command word and its arguments.

### `SubmitCommand(string args)`

Submits a command string for execution.

### `AddBinding(KeyCode key, string command)`

Binds a command to a specific key.

### `RemoveBinding(KeyCode key)`

Removes a key binding.

### `ClearBindings()`

Clears all existing key bindings.

### `Update()`

Called every frame, this method checks for key presses that are bound to commands and executes them if found.
