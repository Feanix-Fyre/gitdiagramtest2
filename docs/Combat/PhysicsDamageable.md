# PhysicsDamageable

Inherits from `MonoBehaviour` and implements `IDamageable`.

## Description

This class provides a concrete implementation of the `IDamageable` interface for objects that have a `Rigidbody`. It is designed for physics props and other non-character objects that can be affected by combat impacts.

## Fields

-   **Rb**: `Rigidbody`
    -   A reference to the `Rigidbody` component of the object.
-   **ForceMultiplier**: `float`
    -   A multiplier applied to the incoming impact force.
-   **onImpacted**: `Action<Impact>`
    -   An event that is invoked when a new impact is received.

## Properties

-   **averageVelocity**: `Vector3` (read-only)
    -   The average velocity of the Rigidbody over the last few frames. (Note: The history tracking for this property appears to be missing from the provided code, but the property itself exists).

## Methods

### SendImpact
`public virtual void SendImpact(Impact impact)`

Implements the `IDamageable` interface. For this class, it simply calls `ReceiveImpact` directly, as it's intended for non-networked or locally controlled physics objects.

-   **Parameters:**
    -   `impact`: The `Impact` data to process.

### ReceiveImpact
`public virtual void ReceiveImpact(Impact impact)`

Implements the `IDamageable` interface. This method applies the impact to the object.
1.  It checks the `impact.ImpactID` against a history of received IDs to prevent processing the same impact multiple times.
2.  It invokes the `onImpacted` event.
3.  If a `Rigidbody` (`Rb`) is assigned, it applies the `impact.ImpactForce` to the Rigidbody at the `impact.Hit.point` using `AddForceAtPosition`.

-   **Parameters:**
    -   `impact`: The `Impact` data containing details about the force and location of the impact.
