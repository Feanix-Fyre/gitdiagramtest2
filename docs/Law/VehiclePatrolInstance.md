# VehiclePatrolInstance

A serializable class that defines the parameters and manages the state for a police vehicle patrol.

## Description

This class represents a potential police vehicle patrol that can be activated based on various game conditions. Unlike other law activities, it seems to be a one-shot event per day rather than a continuous state. It is managed by the `LawController`.

## Fields

-   **Route**: `VehiclePatrolRoute`
    -   A reference to the `VehiclePatrolRoute` asset that the officer's vehicle will follow.
-   **StartTime**: `int`
    -   The in-game time (in 24-hour format) around which this patrol can start.
-   **IntensityRequirement**: `int`
    -   The minimum "Law Enforcement Intensity" level required for this patrol to start.
-   **OnlyIfCurfewEnabled**: `bool`
    -   If true, this patrol can only occur if a curfew is also in effect.

## Core Logic

-   **Evaluation (`Evaluate`)**: This method is called periodically by the `LawController`.
    -   If a patrol is not currently active, it checks if the current time is within a 30-minute window of the `StartTime` and if all other conditions (intensity, curfew) are met.
    -   If all conditions are met and the patrol hasn't already run today (`!startedThisCycle`), it calls `StartPatrol()`.
    -   If a patrol is active, it calls `CheckEnd()` to see if the officer has finished their patrol behaviour.
-   **Activation (`StartPatrol`)**: If the conditions are met and there is an officer available, this method:
    1.  Sets `startedThisCycle` to true to prevent it from running again on the same day.
    2.  Calls `StartVehiclePatrol` on the `LawManager` to create the vehicle, assign an officer, and start the patrol.
    3.  Stores a reference to the `activeOfficer`.
-   **Deactivation (`CheckEnd`)**: The patrol implicitly ends when the assigned officer's `VehiclePatrolBehaviour` is disabled (e.g., they finish the route or are called to an emergency). This method simply checks for that condition and clears the `activeOfficer` reference, making the instance ready to run again on a future day.

## Public Methods

### Evaluate
`public void Evaluate()`

Checks all conditions and calls `StartPatrol` if they are met.

### StartPatrol
`public void StartPatrol()`

Activates the vehicle patrol by calling the `LawManager`.
