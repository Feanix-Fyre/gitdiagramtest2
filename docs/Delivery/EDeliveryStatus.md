# EDeliveryStatus

An enum that defines the possible states of a `DeliveryInstance`.

## Values

-   **InTransit**: The delivery has been ordered and is on its way. The arrival timer is counting down.
-   **Waiting**: The delivery has reached its arrival time, but the destination loading dock is currently occupied. It is waiting for the dock to become free.
-   **Arrived**: The delivery vehicle has arrived at the destination and is parked at the loading dock.
-   **Completed**: The player has unloaded all items from the vehicle, and the delivery is considered finished. The vehicle will be despawned.
