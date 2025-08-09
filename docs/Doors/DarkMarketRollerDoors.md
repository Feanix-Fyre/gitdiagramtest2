# DarkMarketRollerDoors

Inherits from `SensorRollerDoors`.

## Description

This class represents the specific roller doors for the Dark Market area. It extends the functionality of `SensorRollerDoors` by adding a condition that the doors can only be opened if the Dark Market itself is open.

## Methods

### CanOpen
`protected override bool CanOpen()`

Overrides the base `CanOpen` method. It checks the `IsOpen` property of the `DarkMarket` singleton.

-   **Returns:** `true` only if the `DarkMarket` is currently open, otherwise `false`.
