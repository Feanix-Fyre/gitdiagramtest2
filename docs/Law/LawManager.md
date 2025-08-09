# LawManager

Inherits from `Singleton<LawManager>`.

## Description

This singleton manager is the central point for dispatching police units in response to crimes or for scheduled activities like patrols. It interacts with the `PoliceStation` to pull available officers and assign them to tasks.

## Constants

-   **DISPATCH_OFFICER_COUNT**: `2` - The number of officers to dispatch when police are called.
-   **DISPATCH_VEHICLE_USE_THRESHOLD**: `25f` - The distance threshold for when to use a vehicle for dispatch (currently unused in the provided code).

## Methods

### PoliceCalled
`public void PoliceCalled(Player target, Crime crime)`

This method is called when a crime is reported against a specific player. It finds the nearest `PoliceStation` to the player's last known position and dispatches `DISPATCH_OFFICER_COUNT` officers to investigate.

-   **Parameters:**
    -   `target`: The `Player` who committed the crime.
    -   `crime`: The `Crime` that was committed.

### StartFootpatrol
`public PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)`

Creates a new foot patrol. It finds the nearest `PoliceStation`, pulls the requested number of officers from its pool, creates a new `PatrolGroup`, and assigns the officers to it.

-   **Parameters:**
    -   `route`: The `FootPatrolRoute` the officers will follow.
    -   `requestedMembers`: The number of officers to assign to the patrol.
-   **Returns:** The newly created `PatrolGroup`.

### StartVehiclePatrol
`public PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)`

Creates a new vehicle patrol. It finds the nearest `PoliceStation`, pulls one officer from the pool, creates a police vehicle, puts the officer in the vehicle, and assigns them to the vehicle patrol route.

-   **Parameters:**
    -   `route`: The `VehiclePatrolRoute` the officer will follow.
-   **Returns:** The `PoliceOfficer` assigned to the patrol.
