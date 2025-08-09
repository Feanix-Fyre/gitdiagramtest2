# IDamageable

An interface for objects that can take damage or be affected by physical impacts.

## Description

Any class that implements this interface can receive `Impact` data. This allows for a unified way to handle damage and forces from various sources like weapons, explosions, and physics objects.

## Methods

### SendImpact
`void SendImpact(Impact impact)`

This method is intended to be called on the server to send an impact event to all clients. The implementing class would typically contain a `ServerRpc` that then calls an `ObserversRpc` to broadcast the `ReceiveImpact` call.

-   **Parameters:**
    -   `impact`: The `Impact` data to be sent.

### ReceiveImpact
`void ReceiveImpact(Impact impact)`

This method is called on all clients (including the server) to apply the effects of an impact. The implementing class is responsible for handling the damage, applying physics forces, playing effects, etc., based on the data in the `impact` struct.

-   **Parameters:**
    -   `impact`: The `Impact` data containing details about the force, damage, and type of impact.
