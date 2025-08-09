# ConfigurationReplicator

Inherits from `NetworkBehaviour`.

## Description

This class is a critical component for synchronizing `EntityConfiguration` data across the network. Since the configuration data itself is not a `SyncVar`, this replicator provides a set of RPCs (Remote Procedure Calls) to send changes from a client to the server, which then broadcasts them to all other clients.

## Fields

-   **Configuration**: `EntityConfiguration`
    -   A reference to the `EntityConfiguration` that this replicator is responsible for synchronizing.

## Core Logic

The `ConfigurationReplicator` acts as a network communication hub for an `EntityConfiguration`.

1.  **ReplicateField**: This is the main public method. When a `ConfigField`'s value is changed on a client, it calls this method.
2.  **Type Checking**: `ReplicateField` checks the type of the `ConfigField` that was passed in (e.g., `ItemField`, `NPCField`, `ObjectListField`).
3.  **RPC Dispatch**: Based on the field's type, it calls the corresponding `Send...` method (e.g., `SendItemField`, `SendNPCField`). Each of these `Send...` methods is a `ServerRpc`.
4.  **Server to Clients**: The `ServerRpc` method on the server receives the data from the client. It then immediately calls a corresponding `Receive...` method, which is an `ObserversRpc`.
5.  **Client Update**: The `ObserversRpc` is executed on all clients. The `Receive...` method finds the correct `ConfigField` in its local `Configuration` (using the `fieldIndex`) and updates its value with the received data. The `network: false` parameter is used in the final `Set...` call to prevent an infinite loop of RPCs.

This pattern ensures that a change made by one client is sent to the server and then reliably broadcast to all other clients, keeping everyone's configuration UI in sync.

## Public Methods

### ReplicateField
`public void ReplicateField(ConfigField field, NetworkConnection conn = null)`

The main entry point for synchronizing a configuration field. It determines the type of the field and calls the appropriate RPC to send its data over the network.

-   **Parameters:**
    -   `field`: The `ConfigField` that has been changed.
    -   `conn`: An optional network connection, though it appears unused in the current implementation.
