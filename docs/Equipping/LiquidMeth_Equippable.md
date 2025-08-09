# LiquidMeth_Equippable

Inherits from `Equippable_Viewmodel`.

## Description

This class represents an equippable container of liquid meth. Its primary role is to ensure that the visual appearance of the liquid meth (color, etc.) matches the properties defined in its `LiquidMethDefinition`.

## Fields

-   **Visuals**: `LiquidMethVisuals`
    -   A reference to the component that controls the visual appearance of the liquid meth model.

## Methods

### Equip
`public override void Equip(ItemInstance item)`

Overrides the base `Equip` method. It gets the `LiquidMethDefinition` from the `item` and calls the `Setup` method on the `Visuals` component, passing in the definition to configure the model's appearance.

-   **Parameters:**
    -   `item`: The `ItemInstance` of the liquid meth being equipped.
