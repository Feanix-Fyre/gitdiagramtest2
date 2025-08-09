# Surface

Inherits from `MonoBehaviour` and implements `IGUIDRegisterable`.

## Description

This component defines a surface that items can be placed on, such as a wall or a roof. It holds information about the surface type, which faces are valid for placement, and its parent property. It also manages a unique GUID for identification.

## Enums

### ESurfaceType
-   **Wall**
-   **Roof**

### EFace
-   **Front**
-   **Back**
-   **Top**
-   **Bottom**
-   **Left**
-   **Right**

## Fields

-   **SurfaceType**: `ESurfaceType` - The type of this surface.
-   **ValidFaces**: `List<EFace>` - A list of faces on the surface's collider that are valid for item placement.
-   **ParentProperty**: `ScheduleOne.Property.Property` - A reference to the property this surface belongs to.
-   **BakedGUID**: `[SerializeField] protected string` - The string representation of the GUID, saved in the editor.

## Properties

-   **GUID**: `Guid` (read-only) - The unique identifier for this surface.
-   **Container**: `Transform` (read-only) - The transform of the parent property's container.

## Methods

### RegenerateGUID
`public void RegenerateGUID()`

Generates a new GUID and stores it in `BakedGUID`. This can be called from a button in the inspector.

### GetRelativePosition
`public Vector3 GetRelativePosition(Vector3 worldPosition)`

Converts a world-space position to a position relative to this surface's transform.

-   **Parameters:**
    -   `worldPosition`: The position in world space.
-   **Returns:** The position in local space.

### GetRelativeRotation
`public Quaternion GetRelativeRotation(Quaternion worldRotation)`

Converts a world-space rotation to a rotation relative to this surface's transform.

-   **Parameters:**
    -   `worldRotation`: The rotation in world space.
-   **Returns:** The rotation in local space.

### IsPointValid
`public bool IsPointValid(Vector3 point, Collider hitCollider)`

Checks if a given point on a specific face of the collider is a valid placement location, based on the `ValidFaces` list.

-   **Parameters:**
    -   `point`: The world-space point that was hit by the placement raycast.
    -   `hitCollider`: The collider that was hit.
-   **Returns:** True if the point is on a valid face, otherwise false.
