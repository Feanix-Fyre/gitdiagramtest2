# UniqueVisibilityAttribute

The `UniqueVisibilityAttribute` class inherits from `VisibilityAttribute` and adds a `uniquenessCode`. This code is used to ensure that only one instance of this type of attribute can be active at a time for a given player.

## Properties

-   `uniquenessCode`: A string that uniquely identifies this type of attribute.

## Constructors

-   `UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1)`: Creates a new instance of the `UniqueVisibilityAttribute` class.
