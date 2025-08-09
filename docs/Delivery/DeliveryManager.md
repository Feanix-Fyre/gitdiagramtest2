# DeliveryManager

Inherits from `NetworkSingleton<DeliveryManager>` and implements `IBaseSaveable`, `ISaveable`.

## Description

This singleton manager is responsible for tracking all active deliveries in the game. It handles the timing of deliveries, checks for loading bay availability, and updates the status of each `DeliveryInstance`. It is also responsible for saving and loading the state of all deliveries.

## Fields

-   **Deliveries**: `List<DeliveryInstance>`
    -   The master list of all active deliveries.
-   **onDeliveryCreated**: `UnityEvent<DeliveryInstance>`
    -   An event invoked when a new delivery is created and received by the manager.
-   **onDeliveryCompleted**: `UnityEvent<DeliveryInstance>`
    -   An event invoked when a delivery's status is set to `Completed`.

## Core Logic

-   **Time Progression**: The manager subscribes to the `TimeManager`'s `onMinutePass` event. Every in-game minute, it iterates through all active deliveries and calls their `OnMinPass` method to decrement their arrival timer.
-   **Arrival Logic**: When a delivery's `TimeUntilArrival` reaches zero, the manager checks if the destination `LoadingDock` is free.
    -   If it is free, it calls `SetDeliveryState` to `Arrived`, which triggers the spawning of the delivery vehicle.
    -   If it is not free, it sets the delivery's status to `Waiting`.
-   **Completion Logic**: Once a delivery has arrived, the manager monitors the contents of its associated vehicle. If the vehicle is empty for 3 consecutive in-game minutes, the manager sets the delivery's status to `Completed`, which despawns the vehicle and removes the delivery from the active list.
-   **Networking**: The manager uses RPCs (`SendDelivery`, `ReceiveDelivery`, `SetDeliveryState`) to keep the list and status of deliveries synchronized between the server and all clients.
-   **Persistence**: As an `ISaveable`, it implements `GetSaveString` to serialize the list of deliveries and their associated vehicle data into a JSON string for saving.

## Public Methods

### SendDelivery
`public void SendDelivery(DeliveryInstance delivery)`

A `ServerRpc` that clients call to create a new delivery. The server then broadcasts this new delivery to all clients via the `ReceiveDelivery` RPC.

-   **Parameters:**
    -   `delivery`: The `DeliveryInstance` object containing the details of the new delivery.

### GetDelivery
`public DeliveryInstance GetDelivery(string deliveryID)`

Finds and returns a delivery from the `Deliveries` list by its unique ID.

-   **Parameters:**
    -   `deliveryID`: The ID of the delivery to find.
-   **Returns:** The matching `DeliveryInstance`, or `null`.
