# DeliveryInstance

A serializable class that represents a single active or scheduled delivery.

## Description

This class holds all the information for a delivery, including its ID, origin store, destination, contents, and current status. It manages the state of the delivery from the moment it's ordered until it's completed.

## Fields

-   **DeliveryID**: `string` - A unique identifier for this delivery.
-   **StoreName**: `string` - The name of the store the delivery is coming from.
-   **DestinationCode**: `string` - The code identifying the destination property.
-   **LoadingDockIndex**: `int` - The index of the `LoadingDock` at the destination property.
-   **Items**: `StringIntPair[]` - An array of item IDs and quantities included in the delivery.
-   **Status**: `EDeliveryStatus` - The current status of the delivery (e.g., `EnRoute`, `Arrived`).
-   **TimeUntilArrival**: `int` - The remaining time in minutes until the delivery arrives.
-   **onDeliveryCompleted**: `UnityEvent` - An event invoked when the delivery status is set to `Completed`.

## Properties

-   **ActiveVehicle**: `DeliveryVehicle` (read-only)
    -   A reference to the `DeliveryVehicle` GameObject associated with this delivery, once it has arrived.
-   **Destination**: `Property` (read-only)
    -   Gets the destination `Property` object using the `DestinationCode`.
-   **LoadingDock**: `LoadingDock` (read-only)
    -   Gets the destination `LoadingDock` using the `LoadingDockIndex`.

## Methods

### SetStatus
`public void SetStatus(EDeliveryStatus status)`

Updates the status of the delivery. This is the main method for progressing the delivery's state.
-   When set to `Arrived`, it finds the correct `DeliveryVehicle` prefab and activates it at the destination.
-   When set to `Completed`, it deactivates the vehicle and invokes the `onDeliveryCompleted` event.

-   **Parameters:**
    -   `status`: The new `EDeliveryStatus` for the delivery.

### AddItemsToDeliveryVehicle
`public void AddItemsToDeliveryVehicle()`

Populates the associated `DeliveryVehicle`'s storage with the items listed in the `Items` array. It handles splitting items into stacks based on their `StackLimit`.

### OnMinPass
`public void OnMinPass()`

Decrements the `TimeUntilArrival` by one minute. This is called every in-game minute by the `DeliveryManager`.
