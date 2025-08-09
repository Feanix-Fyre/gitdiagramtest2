# OverrideGhostMaterial

Inherits from `MonoBehaviour`.

## Description

A marker component. When the `BuildManager` applies a ghost material (red or white) to a ghost model, it will skip any `MeshRenderer` that has this component in its parent hierarchy. This allows certain parts of a ghost model to retain their original materials instead of being turned into a monochrome preview.
