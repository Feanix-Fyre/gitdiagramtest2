# ConstructStop_Base

Inherits from `MonoBehaviour`.

## Description

A base class for scripts that handle the termination of a construction process (e.g., cancellation). This component is expected to be on a "Construction Handler" prefab.

## Methods

### StopConstruction
`public virtual void StopConstruction()`

This method is called by the `ConstructionManager` when the construction process is stopped. It performs cleanup by:
1.  Calling the `ConstructionStop()` method on the `ConstructUpdate_Base` component to halt any ongoing update logic.
2.  Destroying the construction handler GameObject.
