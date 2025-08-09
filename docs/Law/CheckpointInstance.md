# CheckpointInstance

A serializable class that defines the parameters and manages the state for a police checkpoint.

## Description

This class represents a potential police checkpoint that can be activated or deactivated based on various game conditions like time of day, law intensity, and player proximity. It is managed by the `CheckpointManager`.

## Fields

-   **Location**: `CheckpointManager.ECheckpointLocation`
    -   An enum identifying the physical location of the checkpoint in the world.
-   **Members**: `int`
    -   The number of police officers to spawn at the checkpoint when it becomes active.
-   **StartTime / EndTime**: `int`
    -   The in-game time window (in 24-hour format) during which this checkpoint can be active.
-   **IntensityRequirement**: `int`
    -   The minimum "Law Enforcement Intensity" level required for this checkpoint to become active.
-   **OnlyIfCurfewEnabled**: `bool`
    -   If true, this checkpoint can only be active if a curfew is also in effect.

## Properties

-   **activeCheckpoint**: `RoadCheckpoint` (read-only)
    -   A reference to the `RoadCheckpoint` GameObject that is active for this instance. Will be `null` if the checkpoint is inactive.

## Core Logic

-   **Evaluation (`Evaluate`)**: This method is called periodically by the `LawController`. It checks all the conditions (intensity, time, curfew, player distance) to determine if the checkpoint should be activated.
-   **Activation (`EnableCheckpoint`)**: If the conditions are met and there are officers available, this method calls `SetCheckpointEnabled` on the `CheckpointManager` to spawn the officers and activate the checkpoint prefab. It also subscribes to the `TimeManager`'s `onMinutePass` event to check for deactivation.
-   **Deactivation (`DisableCheckpoint`)**: This method is called by `MinPass` when the time is no longer within the valid range. It tells the `CheckpointManager` to disable the checkpoint and despawn the officers.
-   **Player Proximity (`DistanceRequirementsMet`)**: A key condition for activation/deactivation is that the player must not be too close (within 50 units) to the checkpoint location. This prevents checkpoints from spawning or despawning directly in front of the player. The check is ignored if the player is sleeping.

## Methods

### Evaluate
`public void Evaluate()`

Checks all conditions and calls `EnableCheckpoint` if they are met.

### EnableCheckpoint
`public void EnableCheckpoint()`

Activates the checkpoint by calling the `CheckpointManager`.

### DisableCheckpoint
`public void DisableCheckpoint()`

Deactivates the checkpoint by calling the `CheckpointManager`.
