# DeliveryVehicle

Requires a `LandVehicle` component.

## Description

This class acts as a controller for a vehicle that is used for deliveries. It is attached to a `LandVehicle` prefab and provides methods to "activate" and "deactivate" the vehicle, which essentially means moving it to and from a loading dock and managing its state.

## Fields

-   **GUID**: `string`
    -   A string representation of a GUID used to uniquely identify this vehicle type.

## Properties

-   **Vehicle**: `LandVehicle` (read-only)
    -   A cached reference to the `LandVehicle` component on the same GameObject.
-   **ActiveDelivery**: `DeliveryInstance` (read-only)
    -   A reference to the `DeliveryInstance` that this vehicle is currently servicing.

## Methods

### Activate
`public void Activate(DeliveryInstance instance)`

Activates the delivery vehicle for a specific delivery. This method is called by the `DeliveryManager` when a delivery's status changes to `Arrived`. It performs the following actions:
1.  Stores the `instance` in `ActiveDelivery`.
2.  Gets the destination `LoadingDock` from the delivery instance.
3.  Sets the vehicle as a "static occupant" of the loading dock.
4.  "Parks" the vehicle at the loading dock's associated parking spot.
5.  Makes the vehicle visible.
6.  Sets the vehicle's storage to be fully accessible to the player.
7.  Opens the vehicle's storage doors.

-   **Parameters:**
    -   `instance`: The `DeliveryInstance` that has arrived.

### Deactivate
`public void Deactivate()`

Deactivates the vehicle, typically after a delivery is complete. It performs the following actions:
1.  Takes the vehicle out of its parked state.
2.  Makes the vehicle invisible and moves it to a location far away.
3.  Clears the static occupant and vehicle detector of the `LoadingDock` it was at.
