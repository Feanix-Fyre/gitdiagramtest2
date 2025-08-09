# VisionObscurer

The `VisionObscurer` class is a MonoBehaviour that can be attached to any game object to make it act as a vision obscurer. This means that it can partially or fully block the line of sight of NPCs or other entities that use the vision system.

## Properties

-   `ObscuranceAmount`: A float value between 0 and 1 that determines how much this object obscures vision. A value of 0 means it doesn't obscure vision at all, while a value of 1 means it completely blocks vision.
