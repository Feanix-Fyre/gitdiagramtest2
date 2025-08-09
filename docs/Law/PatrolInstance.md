# PatrolInstance

A serializable class that defines the parameters and manages the state for a police foot patrol.

## Description

This class represents a potential police foot patrol that can be activated or deactivated based on various game conditions like time of day and law intensity. It is managed by the `LawController`.

## Fields

-   **Route**: `FootPatrolRoute`
    -   A reference to the `FootPatrolRoute` asset that the officers will follow.
-   **Members**: `int`
    -   The number of police officers to assign to this patrol.
-   **StartTime / EndTime**: `int`
    -   The in-game time window (in 24-hour format) during which this patrol can be active.
-   **IntensityRequirement**: `int`
    -   The minimum "Law Enforcement Intensity" level required for this patrol to become active.
-   **OnlyIfCurfewEnabled**: `bool`
    -   If true, this patrol can only be active if a curfew is also in effect.

## Properties

-   **ActiveGroup**: `PatrolGroup` (read-only)
    -   A reference to the `PatrolGroup` that is active for this instance. Will be `null` if the patrol is inactive.

## Core Logic

-   **Evaluation (`Evaluate`)**: This method is called periodically by the `LawController`. It checks all the conditions (intensity, time, curfew) to determine if the patrol should be activated. If so, it calls `StartPatrol()`.
-   **Activation (`StartPatrol`)**: If the conditions are met and there are officers available, this method calls `StartFootpatrol` on the `LawManager` to create the `PatrolGroup` and assign officers. It also subscribes `MinPass` to the `TimeManager`'s `onMinutePass` event to check for deactivation.
-   **Deactivation (`MinPass` / `EndPatrol`)**: The `MinPass` method checks every minute if the current time is outside the patrol's active window. If it is, it calls `EndPatrol()`, which disbands the `PatrolGroup` and unsubscribes from the time manager.

## Public Methods

### Evaluate
`public void Evaluate()`

Checks all conditions and calls `StartPatrol` if they are met.

### StartPatrol
`public void StartPatrol()`

Activates the patrol by calling the `LawManager`.

### EndPatrol
`public void EndPatrol()`

Deactivates the patrol by disbanding the associated `PatrolGroup`.
