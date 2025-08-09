# BuildStop_Base

Inherits from `MonoBehaviour`.

## Description

A base class for scripts that handle the termination of a build process. This component is expected to be on a "Build Handler" prefab.

## Methods

### Stop_Building
`public virtual void Stop_Building()`

This method is called by the `BuildManager` when the build process is stopped (e.g., by cancellation). It performs cleanup tasks:
1.  Restores the visibility of the HUD crosshair if no other UI elements are active.
2.  Calls the `Stop()` method on the `BuildUpdate_Base` component to halt any ongoing update logic.
3.  Unloads the "building" input prompts module.
4.  Destroys the build handler GameObject.
