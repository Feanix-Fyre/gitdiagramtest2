# DoorSensor

Requires a `Rigidbody` component.

## Description

This class acts as a trigger volume to detect when players or NPCs are near a `DoorController`. It is responsible for telling the door which side it is being approached from.

## Fields

-   **DetectorSide**: `EDoorSide`
    -   Specifies which side of the door this sensor represents (`Interior` or `Exterior`).
-   **Door**: `DoorController`
    -   A reference to the `DoorController` that this sensor is associated with.

## Core Logic

-   **Performance Optimization**: To save on physics calculations, the `UpdateCollider` method is invoked periodically. It checks the distance to the nearest player and disables the sensor's `Collider` if the player is far away (more than 30 units).
-   **Trigger Detection**: The `OnTriggerStay` method is the core of the sensor's logic.
    -   When a collider enters the trigger, it checks if it's an NPC or a Player.
    -   If it's a valid, conscious NPC that can open doors, it calls `Door.NPCVicinityDetected(DetectorSide)`.
    -   If it's a Player, it calls `Door.PlayerVicinityDetected(DetectorSide)`.
    -   Other colliders are added to an `exclude` list to prevent repeated checks.
