# LoadingDock

Inherits from `MonoBehaviour` and implements `IGUIDRegisterable`, `ITransitEntity`.

## Description

This class defines a loading dock area where vehicles can park. It detects vehicles within its trigger, manages its occupied state, and provides access points for NPCs. It also serves as a "transit entity" for the employee management system, allowing items to be moved to/from the parked vehicle's storage.

## Key Fields & Properties

-   **ParentProperty**: `Property`
    -   A reference to the property this loading dock belongs to.
-   **VehicleDetector**: `VehicleDetector`
    -   A component used to detect when a vehicle enters the dock area.
-   **Parking**: `ParkingLot`
    -   A reference to the associated `ParkingLot` where delivery vehicles will be parked.
-   **accessPoints**: `Transform[]`
    -   An array of transforms defining points where NPCs can access the loading dock (e.g., the back of a parked truck).
-   **IsInUse**: `bool` (read-only)
    -   True if the dock is occupied by either a dynamic vehicle (driven by a player/NPC) or a static vehicle (a delivery truck).
-   **DynamicOccupant**: `LandVehicle` (read-only)
    -   The vehicle currently inside the `VehicleDetector` trigger.
-   **StaticOccupant**: `LandVehicle` (read-only)
    -   The delivery vehicle currently assigned to this dock by the `DeliveryManager`.

## Core Logic

-   **Occupant Detection**: The `RefreshOccupant` method is called periodically. It checks the `VehicleDetector` to see if a slow-moving vehicle is present and sets it as the `DynamicOccupant`.
-   **Transit Entity**: As an `ITransitEntity`, this loading dock can be used in the employee management system. When a vehicle is occupying the dock, the dock's `OutputSlots` are populated with the `ItemSlot`s from the vehicle's storage, allowing employees to be assigned tasks to unload items from the vehicle.
-   **Access Points**: When a vehicle is present, the first `accessPoint` is dynamically moved to the rear of the vehicle's bounding box to provide a valid interaction point for NPCs.

## Public Methods

### SetStaticOccupant
`public void SetStaticOccupant(LandVehicle vehicle)`

Sets a `LandVehicle` as the static occupant of the dock. This is used by the `DeliveryManager` to place a delivery truck at the dock.

-   **Parameters:**
    -   `vehicle`: The delivery vehicle to place at the dock.

### ShowOutline / HideOutline
`public virtual void ShowOutline(Color color)` and `public virtual void HideOutline()`

Methods to control a visual outline effect on the dock, typically used when interacting with it in a management UI.
