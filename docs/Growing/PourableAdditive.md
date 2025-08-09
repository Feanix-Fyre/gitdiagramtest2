# PourableAdditive

Inherits from `Pourable`.

## Description

This class represents the functional prefab that is instantiated to create the visual effect of pouring an additive (like fertilizer). It is used by the `ApplyAdditiveToPot` player task.

## Constants

-   **NormalizedAmountForSuccess**: `float`
    -   The normalized amount of the pouring animation that needs to complete for the action to be considered successful (0.8, or 80%).

## Fields

-   **AdditiveDefinition**: `AdditiveDefinition`
    -   A reference to the `AdditiveDefinition` of the substance being poured.
-   **LiquidColor**: `Color`
    -   The color of the liquid particle stream effect.
-   **pouredAmount**: `private float`
    -   A field to track the amount poured (currently unused in the provided code).

## Methods

### PourAmount
`protected override void PourAmount(float amount)`

Overrides the base `PourAmount` method. Currently, it just calls the base implementation without adding any new logic.

-   **Parameters:**
    -   `amount`: The amount being poured.
