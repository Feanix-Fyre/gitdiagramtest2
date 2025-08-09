# SentryInstance

A serializable class that defines the parameters and manages the state for a police sentry post.

## Description

This class represents a potential police sentry post that can be activated or deactivated based on various game conditions. When active, it pulls officers from a `PoliceStation` and assigns them to a specific `SentryLocation`. It is managed by the `LawController`.

## Fields

-   **Location**: `SentryLocation`
    -   A reference to the `SentryLocation` prefab where the officers will be posted.
-   **Members**: `int`
    -   The number of police officers to assign to this sentry post.
-   **StartTime / EndTime**: `int`
    -   The in-game time window (in 24-hour format) during which this sentry post can be active.
-   **IntensityRequirement**: `int`
    -   The minimum "Law Enforcement Intensity" level required for this post to become active.
-   **OnlyIfCurfewEnabled**: `bool`
    -   If true, this post can only be active if a curfew is also in effect.

## Core Logic

-   **Evaluation (`Evaluate`)**: This method is called periodically by the `LawController`. It checks if the location is currently unmanned and if all conditions (intensity, time, curfew) are met. If so, it calls `StartEntry()`.
-   **Activation (`StartEntry`)**: If the conditions are met and there are officers available, this method:
    1.  Finds the nearest `PoliceStation`.
    2.  Pulls the requested number of officers from the station's pool.
    3.  Assigns each officer to the `SentryLocation` by calling `officer.AssignToSentryLocation()`.
    4.  Subscribes `MinPass` to the `TimeManager`'s `onMinutePass` event to check for deactivation.
-   **Deactivation (`MinPass` / `EndSentry`)**: The `MinPass` method checks every minute if the current time is outside the active window. If it is, it calls `EndSentry()`, which unassigns all officers from the location (allowing them to return to the station pool) and unsubscribes from the time manager.

## Public Methods

### Evaluate
`public void Evaluate()`

Checks all conditions and calls `StartEntry` if they are met.

### StartEntry
`public void StartEntry()`

Activates the sentry post by pulling officers from the nearest station and assigning them to the location.

### EndSentry
`public void EndSentry()`

Deactivates the sentry post by un-assigning all its officers.
