# ACEntry

Inherits from `MonoBehaviour`.

## Description

This class represents an entry in the avatar customization menu. It includes a `DevOnly` flag that, if set to true, will disable the game object when the application is not running in the Unity editor.

## Fields

-   **DevOnly**: `bool`
    -   If true, this entry will only be active in the Unity editor.

## Methods

### Awake
`private void Awake()`

This method is called when the script instance is being loaded. It checks if the `DevOnly` flag is true and if the application is not running in the editor. If both conditions are met, it deactivates the game object.
