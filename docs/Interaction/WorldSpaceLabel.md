# WorldSpaceLabel

A class for creating and managing a UI text label that exists at a position in the 3D world.

## Description

This is not a `MonoBehaviour`. Instead, it's a regular C# class that acts as a controller for a UI element prefab. When a `WorldSpaceLabel` is created, it instantiates a UI prefab from the `InteractionManager` and adds itself to the manager's list of active labels. The `InteractionManager` then calls `RefreshDisplay` on it every frame.

## Fields

-   **text**: `string` - The text content to be displayed.
-   **color**: `Color32` - The color of the text.
-   **position**: `Vector3` - The world-space position where the label should appear.
-   **scale**: `float` - A multiplier for the label's size.
-   **rect**: `RectTransform` - A reference to the `RectTransform` of the instantiated UI element.
-   **textComp**: `Text` - A reference to the `Text` component of the instantiated UI element.
-   **active**: `bool` - A flag to control the visibility of the label.

## Constructors

### WorldSpaceLabel(string _text, Vector3 _position)
Creates a new world-space label.
1.  Instantiates the UI prefab from the `InteractionManager`.
2.  Gets references to the `RectTransform` and `Text` components.
3.  Adds itself to the `InteractionManager`'s list of active labels.
4.  Calls `RefreshDisplay()` to set its initial state.

## Methods

### RefreshDisplay
`public void RefreshDisplay()`

Called every frame by the `InteractionManager`. It updates the position and appearance of the UI element.
-   It hides the label if it is behind the camera or if `active` is false.
-   It updates the `text` and `color` of the `textComp`.
-   It converts the world `position` to a screen position and sets the `rect`'s position.
-   It calculates a new scale for the label based on its distance from the camera, making it smaller as it gets farther away.

### Destroy
`public void Destroy()`

Removes the label from the `InteractionManager`'s list and destroys the associated UI GameObject.
