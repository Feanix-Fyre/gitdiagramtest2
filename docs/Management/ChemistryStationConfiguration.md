# ChemistryStationConfiguration

Inherits from `EntityConfiguration`.

## Description

This class holds the configuration for a `ChemistryStation`. It manages the assignment of a `Chemist` employee, the recipe to be produced, and the destination for the output products.

## Fields

-   **AssignedChemist**: `NPCField`
    -   A configuration field to select the `Chemist` employee who will operate this station.
-   **Recipe**: `StationRecipeField`
    -   A configuration field to select the `StationRecipe` that this station should produce.
-   **Destination**: `ObjectField`
    -   A configuration field to select the `ITransitEntity` (e.g., a storage shelf) where the finished products will be moved.

## Properties

-   **Station**: `ChemistryStation` (read-only)
    -   A reference to the `ChemistryStation` this configuration belongs to.
-   **DestinationRoute**: `TransitRoute` (read-only)
    -   The `TransitRoute` from this station to the selected `Destination`.

## Core Logic

-   **Initialization**: The constructor creates the `NPCField`, `StationRecipeField`, and `ObjectField` and sets up their event listeners.
-   **Transit Route Management**:
    -   When the `Destination` object is changed via the UI, the `DestinationChanged` method is called.
    -   It destroys the old `DestinationRoute` (if one existed) and creates a new one to the new destination.
    -   The route's visuals are activated when this configuration is selected in the UI (`Selected` method) and deactivated when it's deselected (`Deselected` method).
-   **Persistence**: It implements `ShouldSave` and `GetSaveString` to save the configuration data (the selected recipe and the GUID of the destination object) to a JSON string.

## Methods

### DestinationFilter
`public bool DestinationFilter(BuildableItem obj, out string reason)`

A filter method used by the `Destination` `ObjectField`. It ensures that only objects that implement `ITransitEntity` and are not the station itself can be selected as a destination.
