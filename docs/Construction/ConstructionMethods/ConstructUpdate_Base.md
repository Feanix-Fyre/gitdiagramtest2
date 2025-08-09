# ConstructUpdate_Base

Inherits from `MonoBehaviour`.

## Description

A base class for scripts that handle the per-frame update logic of a construction process (placing or moving an object). This component is expected to be on a "Construction Handler" prefab.

## Fields

-   **MovedConstructable**: `Constructable_GridBased`
    -   A reference to the constructable object that is being moved. This is `null` if a new object is being placed instead of an existing one being moved.

## Properties

-   **isMoving**: `bool` (read-only)
    -   A convenience property that returns `true` if `MovedConstructable` is not null.

## Methods

### Update / LateUpdate
`protected virtual void Update()` and `protected virtual void LateUpdate()`

Empty virtual methods intended to be overridden by derived classes to implement the core placement logic, such as updating the ghost model's position and checking for valid placement.

### ConstructionStop
`public virtual void ConstructionStop()`

A virtual method called when the construction process is stopped or cancelled. Its base implementation checks if an object was being moved (`MovedConstructable != null`) and, if so, restores its visibility.
