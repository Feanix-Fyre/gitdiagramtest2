# BuildUpdate_Base

Inherits from `MonoBehaviour`.

## Description

An abstract base class for scripts that handle the per-frame logic of a build process, such as updating the position and state of the ghost model. This component is expected to be on a "Build Handler" prefab.

## Methods

### Stop
`public virtual void Stop()`

A virtual method that can be overridden by derived classes to perform any necessary cleanup when the build update loop is stopped. By default, it does nothing.
