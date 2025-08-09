# CheckpointManager

Inherits from `NetworkSingleton<CheckpointManager>`.

## Description

This singleton manager is responsible for managing all police checkpoint locations in the game. It holds references to the `RoadCheckpoint` prefabs and provides methods to enable or disable them.

## Enums

### ECheckpointLocation
An enum to identify the different checkpoint locations.
-   `Western`
-   `Docks`
-   `NorthResidential`
-   `WestResidential`

## Fields

-   **WesternCheckpoint**: `RoadCheckpoint`
-   **DocksCheckpoint**: `RoadCheckpoint`
-   **NorthResidentialCheckpoint**: `RoadCheckpoint`
-   **WestResidentialCheckpoint**: `RoadCheckpoint`
    -   References to the `RoadCheckpoint` prefabs for each location.

## Core Logic

-   **State Synchronization**: When a new client joins (`OnSpawnServer`), the manager checks the activation state of each checkpoint and calls the appropriate `Enable` method on the `RoadCheckpoint` to synchronize its state for the new client.
-   **Officer Assignment**: When `SetCheckpointEnabled` is called with `enabled: true`, it pulls the requested number of officers from the `PoliceStation`'s officer pool and assigns them to the checkpoint using `officer.AssignToCheckpoint()`.

## Public Methods

### SetCheckpointEnabled
`public void SetCheckpointEnabled(ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)`

Enables or disables a specific checkpoint. This is a server-side method.

-   **Parameters:**
    -   `checkpoint`: The location of the checkpoint to modify.
    -   `enabled`: `true` to enable the checkpoint, `false` to disable it.
    -   `requestedOfficers`: The number of officers to assign to the checkpoint if enabling.

### GetCheckpoint
`public RoadCheckpoint GetCheckpoint(ECheckpointLocation loc)`

A helper method to get the `RoadCheckpoint` prefab associated with a given location enum.

-   **Parameters:**
    -   `loc`: The checkpoint location.
-   **Returns:** The corresponding `RoadCheckpoint` object.
