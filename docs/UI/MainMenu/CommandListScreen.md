# CommandListScreen

The `CommandListScreen` class is a UI screen that displays a list of all available console commands to the player. It is part of the main menu system.

## Properties

-   `CommandEntryContainer`: A `RectTransform` that serves as the container for the individual command entry UI elements.
-   `CommandEntryPrefab`: A `RectTransform` prefab used to instantiate each command entry in the list.

## Methods

### `Start()`

This method is called when the script instance is being loaded. It populates the command list screen by iterating through all the available `ConsoleCommand` objects in the `Console` class. For each command, it instantiates a `CommandEntryPrefab`, populates it with the command's details (word, description, and example usage), and adds it to the `CommandEntryContainer`.
