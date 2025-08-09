# LawActivitySettings

A serializable class that holds arrays of different law enforcement activity instances.

## Description

This class acts as a container for all the different types of scheduled or conditional police activities, such as patrols, checkpoints, and curfews. It provides a single point to evaluate all of them at once. An instance of this class is held by the `LawController`.

## Fields

-   **Patrols**: `PatrolInstance[]`
    -   An array of all possible foot patrol instances.
-   **Checkpoints**: `CheckpointInstance[]`
    -   An array of all possible road checkpoint instances.
-   **Curfews**: `CurfewInstance[]`
    -   An array of all possible curfew instances.
-   **VehiclePatrols**: `VehiclePatrolInstance[]`
    -   An array of all possible vehicle patrol instances.
-   **Sentries**: `SentryInstance[]`
    -   An array of all possible static sentry instances.

## Methods

### Evaluate
`public void Evaluate()`

Iterates through all the activity arrays (`Patrols`, `Checkpoints`, etc.) and calls the `Evaluate()` method on each individual instance. This is the main method used by the `LawController` to determine which police activities should be active based on the current game state.

### End
`public void End()`

A method to gracefully end activities. Currently, it only signals active curfews that they should disable themselves at the next opportunity.

### OnLoaded
`public void OnLoaded()`

Called when game data is loaded. It re-evaluates all curfew instances to ensure their state is correct after loading a save.
