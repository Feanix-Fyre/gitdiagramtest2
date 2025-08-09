# VisibilityAttribute

The `VisibilityAttribute` class represents an attribute that can affect a player's visibility. It has a `pointsChange` and a `multiplier` that are applied to the player's visibility score. When a `VisibilityAttribute` is created, it adds itself to the `activeAttributes` list of the local player's `PlayerVisibility` component.

## Properties

-   `name`: The name of the attribute.
-   `pointsChange`: The amount to change the player's visibility score by.
-   `multiplier`: A multiplier to apply to the player's visibility score.

## Constructors

-   `VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1)`: Creates a new instance of the `VisibilityAttribute` class and adds it to the local player's `activeAttributes` list.

## Methods

-   `Delete()`: Removes the attribute from the local player's `activeAttributes` list.
